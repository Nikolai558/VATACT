using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatactLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Cid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string AllInfo { get { return $"{Cid} - {FullName}"; } }
        public List<CallsignModel> AllCallsigns { get; set; }
        public double TotalArtccMinutes { get; set; }
        public double TotalOtherMinutes { get; set; }
        public List<string> ArtccCallsigns 
        {
            get 
            {
                List<string> output = new List<string>();
                foreach (CallsignModel callsign in AllCallsigns)
                {
                    foreach (string prefix in GlobalConfig.ArtccDictionary[GlobalConfig.SelectedArtcc])
                    {
                        if (callsign.Callsign.IndexOf(prefix, 0, 4) != -1)
                        {
                            foreach (string suffix in GlobalConfig.ControlSuffix)
                            {
                                if (callsign.Callsign.IndexOf(suffix, callsign.Callsign.Count()-4, 4) != -1)
                                {
                                    if (!output.Contains(callsign.Callsign))
                                    {
                                        output.Add(callsign.Callsign);
                                    }
                                }
                            }
                        }
                    }
                }
                return output;
            }
        }
        public List<string> OtherCallsigns 
        {
            get 
            {
                List<string> output = new List<string>();
                List<string> artccCallsigns = ArtccCallsigns;

                foreach (CallsignModel callsign in AllCallsigns)
                {
                    if (artccCallsigns.Contains(callsign.Callsign))
                    {
                        continue;
                    }
                    else if (output.Contains(callsign.Callsign))
                    {
                        continue;
                    }
                    else
                    {
                        output.Add(callsign.Callsign);
                    }
                }

                return output;
            } 
        }

        public List<string> ArtccCallsignsAndHours 
        {
            get 
            {
                List<string> artccCallsigns = ArtccCallsigns;
                List<string> output = new List<string>();

                if (artccCallsigns.Count > 0)
                {
                    foreach (string callsign in artccCallsigns)
                    {
                        double totalTime = 0;
                        foreach (CallsignModel callsignModel in AllCallsigns)
                        {
                            if (callsignModel.Callsign == callsign)
                            {
                                totalTime += callsignModel.MinutesOnCallsign;
                            }
                        }

                        TimeSpan time = TimeSpan.FromMinutes(totalTime);
                        string hours = $"{(int)time.TotalHours}:{time.Minutes}:{time.Seconds}";

                        output.Add($"{callsign} - {hours}");
                    }
                }
                else
                {
                    output.Add("NONE");
                }

                return output;
            }
        }
        public List<string> OtherCallsignsAndHours 
        {
            get 
            {
                List<string> otherCallsigns = OtherCallsigns;
                List<string> output = new List<string>();

                if (otherCallsigns.Count > 0)
                {
                    foreach (string otherCallsign in otherCallsigns)
                    {
                        double totalTime = 0;
                        foreach (CallsignModel callsign in AllCallsigns)
                        {
                            if (callsign.Callsign == otherCallsign)
                            {
                                totalTime += callsign.MinutesOnCallsign;
                            }
                        }
                    }
                }
                else
                {
                    output.Add("None");
                }

                return output;
            }
        }
    }
}
