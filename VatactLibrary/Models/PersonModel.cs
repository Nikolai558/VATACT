using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatactLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Unique ID for the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Vatsim's assigned CID for the person.
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// Person First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Person Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Person Full Name
        /// </summary>
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        /// <summary>
        /// CID of person with their Full Name
        /// </summary>
        public string AllInfo { get { return $"{Cid} - {FullName}"; } }

        /// <summary>
        /// List of Callsign Models for all of the connections this person made
        /// </summary>
        public List<CallsignModel> AllCallsigns { get; set; }

        /// <summary>
        /// Total Artcc Minutes
        /// </summary>
        public double TotalArtccMinutes { get; set; }

        /// <summary>
        /// Total Artcc Hours
        /// </summary>
        public string TotalArtccHours 
        { 
            get 
            {
                TimeSpan time = TimeSpan.FromMinutes(TotalArtccMinutes);
                string hours = GetTimeFormat(time);
                return hours;
            }
        }

        /// <summary>
        /// Total Other Minutes
        /// </summary>
        public double TotalOtherMinutes { get; set; }

        /// <summary>
        /// Total Other Hours
        /// </summary>
        public string TotalOtherHours
        {
            get
            {
                TimeSpan time = TimeSpan.FromMinutes(TotalOtherMinutes);
                string hours = GetTimeFormat(time);
                return hours;
            }
        }

        /// <summary>
        /// Artcc Callsigns used, no duplicates are returned.
        /// </summary>
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

        /// <summary>
        /// Other Callsigns used, no duplicates are returned.
        /// </summary>
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

        /// <summary>
        /// Artcc Callsigns Formated with the Hours for that Callsign
        /// </summary>
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
                        string hours = GetTimeFormat(time);
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

        /// <summary>
        /// Other Callsigns Formated with the Hours for that Callsign
        /// </summary>
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
                        TimeSpan time = TimeSpan.FromMinutes(totalTime);
                        string hours = GetTimeFormat(time);
                        output.Add($"{otherCallsign} - {hours}");
                    }
                }
                else
                {
                    output.Add("None");
                }

                return output;
            }
        }

        /// <summary>
        /// Bool to see if they have met the minimum required hours.
        /// </summary>
        public bool MetMinReqHours { get; set; }

        /// <summary>
        /// Formats the time on callsign or total Hours in HH:MM:SS
        /// </summary>
        /// <param name="time">TimeSpan from Minutes</param>
        /// <returns>String formated HH:MM:SS</returns>
        private string GetTimeFormat(TimeSpan time) 
        {
            string output;

            if (time.TotalHours > 23)
            {
                string minutes;
                string seconds;

                if (time.Minutes < 10 && time.Seconds < 10)
                {
                    minutes = $"0{time.Minutes}";
                    seconds = $"0{time.Seconds}";
                    output = $"{(int)time.TotalHours}:{minutes}:{seconds}";
                }
                else if (time.Minutes < 10 && time.Seconds > 10)
                {
                    minutes = $"0{time.Minutes}";
                    output = $"{(int)time.TotalHours}:{minutes}:{time.Seconds}";
                }
                else if (time.Minutes > 10 && time.Seconds < 10)
                {
                    seconds = $"0{time.Seconds}";
                    output = $"{(int)time.TotalHours}:{time.Minutes}:{seconds}";
                }
                else
                {
                    output = $"{(int)time.TotalHours}:{time.Minutes}:{time.Seconds}";
                }
            }
            else
            {
                output = time.ToString("c");

            }

            return output;
        }
    }
}
