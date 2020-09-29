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
        /// <summary>
        /// API Call to Vatsim Server to get the Person Name from their CID.
        /// </summary>
        /// <param name="person">Person Model</param>
        /// <returns>Doesn't return anything but will set the name for the Person Model passed in.</returns>
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

        /// <summary>
        /// API Call to Vatsim servers to get the Callsigns used for the Person Model.
        /// </summary>
        /// <param name="person">Person Model</param>
        /// <returns>Doesn't return anything but will set the Callsigns Used for the Person Model passed in.</returns>
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
                                MinutesOnCallsign = double.Parse(connection["minutes_on_callsign"].ToString()),
                                StartDateTime = (DateTime)connection["start"]
                            };

                            if (connection["end"] != null)
                            {
                                DateTime endDateTime = (DateTime)connection["end"];
                                if (endDateTime.ToString("MM") == GlobalConfig.SelectedMonth && endDateTime.ToString("yyyy") == GlobalConfig.SelectedYear)
                                {
                                    c.EndDateTime = (DateTime)connection["end"];
                                }
                                else if (int.Parse(endDateTime.ToString("MM")) > int.Parse(GlobalConfig.SelectedMonth) && endDateTime.ToString("yyyy") == GlobalConfig.SelectedYear)
                                {
                                    endDateTime = new DateTime(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth), DateTime.DaysInMonth(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth)), 23, 59, 59);
                                    c.EndDateTime = endDateTime;
                                }
                                else if (int.Parse(endDateTime.ToString("MM")) == 1 && int.Parse(endDateTime.ToString("yyyy")) > int.Parse(GlobalConfig.SelectedYear))
                                {
                                    endDateTime = new DateTime(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth), DateTime.DaysInMonth(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth)), 23, 59, 59);
                                    c.EndDateTime = endDateTime;
                                }
                                else
                                {
                                    string message = $"CID-{person.Cid}, START-{c.StartDateTime.ToString()}, END-{connection["end"]},  SELECTED-{GlobalConfig.SelectedMonth}/{GlobalConfig.SelectedYear}";

                                    throw new NotImplementedException($"ERROR: {message}");
                                }
                            }
                            else
                            {
                                DateTime currentDateTime = DateTime.UtcNow;
                                DateTime newEndDateTime;

                                if (currentDateTime.ToString("MM") == GlobalConfig.SelectedMonth && currentDateTime.ToString("yyyy") == GlobalConfig.SelectedYear)
                                {
                                    c.EndDateTime = currentDateTime;
                                    // Controller is currently online, Current Month/Year matches Selected Month/Year
                                    // Set "End DateTime" to current UTC DateTime
                                }
                                else if (int.Parse(currentDateTime.ToString("MM")) - 1 == int.Parse(GlobalConfig.SelectedMonth) && currentDateTime.ToString("yyyy") == GlobalConfig.SelectedYear)
                                {
                                    newEndDateTime = new DateTime(int.Parse(GlobalConfig.SelectedYear),int.Parse(GlobalConfig.SelectedMonth), DateTime.DaysInMonth(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth)), 23, 59, 59);
                                    c.EndDateTime = newEndDateTime;
                                    // Controller is currently online, Current Month - 1 /Year Matches Selected Month/Year
                                    // Set "End DateTime" to the Last Selected Month/Day/Year/hour/minute/second of the selectedMonth
                                }
                                else if (int.Parse(currentDateTime.ToString("MM")) < int.Parse(GlobalConfig.SelectedMonth) && int.Parse(GlobalConfig.SelectedYear) < int.Parse(currentDateTime.ToString("yyyy")))
                                {
                                    newEndDateTime = new DateTime(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth), DateTime.DaysInMonth(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth)), 23, 59, 59);
                                    c.EndDateTime = newEndDateTime;
                                    // Controller is controlling from previous year into next year ( 12/31/2020 23:30:00 to 01/01/2020 05:05:05 )
                                    // Set "End DateTime" to the Last Selected Month/Day/Year/hour/minute/second of the selectedYear
                                }
                                else
                                {
                                    // CATCH ALl ERROR FOR CONTROLING INTO DIFERENT YEAR/MONTH ( or mistake in API )
                                    // Throw an exception. This Code should never be reached unless there is an error in API or unless the user broke something
                                    string message = $"ONLINE: CID-{person.Cid}, START-{c.StartDateTime.ToString()}, {GlobalConfig.SelectedMonth}/{GlobalConfig.SelectedYear}";

                                    throw new NotImplementedException($"ERROR: {message}");
                                }
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
                        CallsignModel c = new CallsignModel
                        {
                            Id = id,
                            Callsign = connection["callsign"].ToString(),
                            MinutesOnCallsign = double.Parse(connection["minutes_on_callsign"].ToString()),
                            StartDateTime = (DateTime)connection["start"],
                        };

                        if (connection["end"] != null)
                        {
                            DateTime endDateTime = (DateTime)connection["end"];
                            if (endDateTime.ToString("MM") == GlobalConfig.SelectedMonth && endDateTime.ToString("yyyy") == GlobalConfig.SelectedYear)
                            {
                                c.EndDateTime = (DateTime)connection["end"];
                            }
                            else if (int.Parse(endDateTime.ToString("MM")) > int.Parse(GlobalConfig.SelectedMonth) && endDateTime.ToString("yyyy") == GlobalConfig.SelectedYear)
                            {
                                endDateTime = new DateTime(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth), DateTime.DaysInMonth(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth)), 23, 59, 59);
                                c.EndDateTime = endDateTime;
                            }
                            else if (int.Parse(endDateTime.ToString("MM")) == 1 && int.Parse(endDateTime.ToString("yyyy")) > int.Parse(GlobalConfig.SelectedYear))
                            {
                                endDateTime = new DateTime(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth), DateTime.DaysInMonth(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth)), 23, 59, 59);
                                c.EndDateTime = endDateTime;
                            }
                            else
                            {
                                string message = $"CID-{person.Cid}, START-{c.StartDateTime.ToString()}, END-{connection["end"]},  SELECTED-{GlobalConfig.SelectedMonth}/{GlobalConfig.SelectedYear}";

                                throw new NotImplementedException($"ERROR: {message}");
                            }
                        }
                        else
                        {
                            DateTime currentDateTime = DateTime.UtcNow;
                            DateTime newEndDateTime;

                            if (currentDateTime.ToString("MM") == GlobalConfig.SelectedMonth && currentDateTime.ToString("yyyy") == GlobalConfig.SelectedYear)
                            {
                                c.EndDateTime = currentDateTime;
                                // Controller is currently online, Current Month/Year matches Selected Month/Year
                                // Set "End DateTime" to current UTC DateTime
                            }
                            else if (int.Parse(currentDateTime.ToString("MM")) - 1 == int.Parse(GlobalConfig.SelectedMonth) && currentDateTime.ToString("yyyy") == GlobalConfig.SelectedYear)
                            {
                                newEndDateTime = new DateTime(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth), DateTime.DaysInMonth(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth)), 23, 59, 59);
                                c.EndDateTime = newEndDateTime;
                                // Controller is currently online, Current Month - 1 /Year Matches Selected Month/Year
                                // Set "End DateTime" to the Last Selected Month/Day/Year/hour/minute/second of the selectedMonth
                            }
                            else if (int.Parse(currentDateTime.ToString("MM")) < int.Parse(GlobalConfig.SelectedMonth) && int.Parse(GlobalConfig.SelectedYear) < int.Parse(currentDateTime.ToString("yyyy")))
                            {
                                newEndDateTime = new DateTime(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth), DateTime.DaysInMonth(int.Parse(GlobalConfig.SelectedYear), int.Parse(GlobalConfig.SelectedMonth)), 23, 59, 59);
                                c.EndDateTime = newEndDateTime;
                                // Controller is controlling from previous year into next year ( 12/31/2020 23:30:00 to 01/01/2020 05:05:05 )
                                // Set "End DateTime" to the Last Selected Month/Day/Year/hour/minute/second of the selectedYear
                            }
                            else
                            {
                                // CATCH ALl ERROR FOR CONTROLING INTO DIFERENT YEAR/MONTH ( or mistake in API )
                                // Throw an exception. This Code should never be reached unless there is an error in API or unless the user broke something
                                string message = $"ONLINE: CID-{person.Cid}, START-{c.StartDateTime.ToString()}, {GlobalConfig.SelectedMonth}/{GlobalConfig.SelectedYear}";

                                throw new NotImplementedException($"ERROR: {message}");
                            }
                        }

                        output.Add(c);
                        id += 1;
                    }
                }
                person.AllCallsigns = output;
            }
        }

        /// <summary>
        /// Version Check
        /// </summary>
        /// <returns>(Github Version, Error Message)</returns>
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

        /// <summary>
        /// Calculate the cut off month and year
        /// </summary>
        /// <returns>(Cut off Month, Cut off Year)</returns>
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
