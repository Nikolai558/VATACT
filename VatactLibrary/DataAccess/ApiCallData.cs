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
        public async Task GetCidName(PersonModel person) 
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://api.vatsim.net/api/ratings/{person.Cid}/?format=json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JObject obj = JObject.Parse(responseBody);
            person.FirstName = (string)obj["name_first"];
            person.LastName = (string)obj["name_last"];
        }

        public async Task GetCallsignsUsed(PersonModel person) 
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://api.vatsim.net/api/ratings/{person.Cid}/atcsessions/?format=json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JObject obj = JObject.Parse(responseBody);

            int id = 1;
            //int cutOffMonth, cutOffYear = CutoffMonthYear()[0], [1];
        }

        private List<int> CutoffMonthYear() 
        {
            List<int> output = new List<int>();
            if (GlobalConfig.SelectedMonth == 01)
            {
                int cutOffMonth = 12;
                int cutOffYear = GlobalConfig.SelectedYear - 1;
                output.Add(cutOffMonth);
                output.Add(cutOffYear);
            }
            else
            {
                int cutOffMonth = GlobalConfig.SelectedMonth - 1;
                int cutOffYear = GlobalConfig.SelectedYear;
                output.Add(cutOffMonth);
                output.Add(cutOffYear);
            }
            return output;
        }
    }
}
