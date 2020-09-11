using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
                            CallsignModel c = new CallsignModel
                            {
                                Id = id,
                                Callsign = connection["callsign"].ToString(),
                                MinutesOnCallsign = double.Parse(connection["minutes_on_callsign"].ToString())
                            };

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
                        CallsignModel c = new CallsignModel
                        {
                            Id = id,
                            Callsign = connection["callsign"].ToString(),
                            MinutesOnCallsign = double.Parse(connection["minutes_on_callsign"].ToString())
                        };

                        output.Add(c);
                        id += 1;
                    }
                }
                person.AllCallsigns = output;
            }
        }

        private static (int, int) CutoffMonthYear() 
        {
            int cutOffMonth;
            int cutOffYear;

            if (GlobalConfig.SelectedMonth == 01)
            {
                cutOffMonth = 12;
                cutOffYear = GlobalConfig.SelectedYear - 1;
            }
            else
            {
                cutOffMonth = GlobalConfig.SelectedMonth - 1;
                cutOffYear = GlobalConfig.SelectedYear;
            }
            return (cutOffMonth, cutOffYear);
        }
    }
}
