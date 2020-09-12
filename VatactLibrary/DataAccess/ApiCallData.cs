using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VatactLibrary.Models;

namespace VatactLibrary.DataAccess
{
    public class ApiCallData
    {
        public static async Task GetCidName(PersonModel person) 
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://api.vatsim.net/api/ratings/{person.Cid}/?format=json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JObject obj = JObject.Parse(responseBody);
            person.FirstName = (string)obj["name_first"];
            person.LastName = (string)obj["name_last"];
        }

        public static async Task GetCallsignsUsed(PersonModel person)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://api.vatsim.net/api/ratings/{person.Cid}/atcsessions/?format=json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JObject obj = JObject.Parse(responseBody);

            int id = 1;
            (int cutOffMonth, int cutOffYear) = CutoffMonthYear();

            if (obj["next"] != null)
            {
                List<JObject> allResponseBody = new List<JObject>();
                int pageCounter = 2;
                bool needMorePages = true;
                bool resultsPageIsNull = false;
                allResponseBody.Add(obj);

                if (obj["results"].Count() == 0)
                {
                    resultsPageIsNull = true;
                }
                if (!resultsPageIsNull)
                {
                    string lastConnectionOnPage = (string)obj["results"].Last()["start"];
                    int lastConnectionMonth = int.Parse(lastConnectionOnPage.Substring(0, 2));
                    int lastConnectionYear = int.Parse(lastConnectionOnPage.Substring(6, 4));


                    if (lastConnectionYear < cutOffYear)
                    {
                        needMorePages = false;
                    }
                    else if (lastConnectionYear == cutOffYear)
                    {
                        if (lastConnectionMonth <= cutOffMonth)
                        {
                            needMorePages = false;
                        }
                        else
                        {
                            needMorePages = true;
                        }
                    }
                }

                while (needMorePages)
                {
                    HttpResponseMessage responseOne = await client.GetAsync($"https://api.vatsim.net/api/ratings/{person.Cid}/atcsessions/?format=json&page={pageCounter}");
                    response.EnsureSuccessStatusCode();
                    responseBody = await responseOne.Content.ReadAsStringAsync();

                    obj = JObject.Parse(responseBody);

                    if (obj["next"] == null)
                    {
                        needMorePages = false;
                        break;
                    }

                    string lastConnectionOnPage = (string)obj["results"].Last()["start"];
                    int lastConnectionMonth = int.Parse(lastConnectionOnPage.Substring(0, 2));
                    int lastConnectionYear = int.Parse(lastConnectionOnPage.Substring(6, 4));


                    if (lastConnectionYear < cutOffYear)
                    {
                        needMorePages = false;
                    }
                    else if (lastConnectionYear == cutOffYear)
                    {
                        if (lastConnectionMonth <= cutOffMonth)
                        {
                            needMorePages = false;
                        }
                        else
                        {
                            needMorePages = true;
                        }
                    }
                    allResponseBody.Add(obj);
                    pageCounter += 1;
                }
            
                List<CallsignModel> output = new List<CallsignModel>();

                foreach (JObject allPages in allResponseBody)
                {
                    foreach (JObject connection in allPages["results"])
                    {
                        string startDate = (string)connection["start"];
                        string month = startDate.Substring(0, 2);
                        string year = startDate.Substring(6, 4);

                        if (month == GlobalConfig.SelectedMonth.ToString() & year == GlobalConfig.SelectedYear.ToString())
                        {
                            // TODO (01 / 02) - Verify "End Date" does not go into next month.

                            CallsignModel c = new CallsignModel
                            {
                                Id = id,
                                Callsign = connection["callsign"].ToString(),
                                MinutesOnCallsign = double.Parse(connection["minutes_on_callsign"].ToString()),
                                StartDateTime = (DateTime)connection["start"]
                            };

                            if (connection["end"] != null)
                            {
                                c.EndDateTime = (DateTime)connection["end"];
                            }
                            else
                            {
                                // Controller is curently controlling and online.
                                // TODO - Need to figure out how to handle when the controller is online.
                            }

                            output.Add(c);
                            id += 1;
                        }
                    }
                }
                person.AllCallsigns = output;
            }
            else
            {
                List<CallsignModel> output = new List<CallsignModel>();

                foreach (JObject connection in obj["results"])
                {
                    string startDate = (string)connection["start"];
                    string month = startDate.Substring(0, 2);
                    string year = startDate.Substring(6, 4);

                    if (month == GlobalConfig.SelectedMonth.ToString() & year == GlobalConfig.SelectedYear.ToString())
                    {
                        // TODO (02 / 02) - Verify "End Date" does not go into next month.

                        CallsignModel c = new CallsignModel
                        {
                            Id = id,
                            Callsign = connection["callsign"].ToString(),
                            MinutesOnCallsign = double.Parse(connection["minutes_on_callsign"].ToString()),
                            StartDateTime = (DateTime)connection["start"],
                        };

                        if (connection["end"] != null)
                        {
                            c.EndDateTime = (DateTime)connection["end"];
                        }
                        else
                        {
                            // Controller is curently controlling and online.
                            // TODO - Need to figure out how to handle when the controller is online.
                        }

                        output.Add(c);
                        id += 1;
                    }
                }
                person.AllCallsigns = output;
            }
        }

        public static (string, string) GetCurrentVersion() 
        {
            string githubLink = "https://raw.githubusercontent.com/Nikolai558/VATACT/master/README.md";
            string currentVersion = "";
            string errorMessage = "";

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(githubLink).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        string result = content.ReadAsStringAsync().Result;

                        if (result == "404: Not Found")
                        {
                            errorMessage = "404: Not Found";
                            return (currentVersion, errorMessage);
                        }


                        // This is what we are looking for: #### --Current_Version: V-0.0.8--23
                        string[] lines = Regex.Split(result, "\n\\s*");

                        foreach (string line in lines)
                        {
                            if (line.Count() < 23)
                            {
                                continue;
                            }
                            if (line.Substring(0, 23) == "#### --Current_Version:")
                            {
                                currentVersion = line.Substring(24, 7);
                            }
                        }
                    }
                }
            }
            return (currentVersion, errorMessage);
        }

        private static (int, int) CutoffMonthYear() 
        {
            int cutOffMonth;
            int cutOffYear;

            if (int.Parse(GlobalConfig.SelectedMonth) == 01)
            {
                cutOffMonth = 12;
                cutOffYear = int.Parse(GlobalConfig.SelectedYear) - 1;
            }
            else
            {
                cutOffMonth = int.Parse(GlobalConfig.SelectedMonth) - 1;
                cutOffYear = int.Parse(GlobalConfig.SelectedYear);
            }
            return (cutOffMonth, cutOffYear);
        }
    }
}
