﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VatactLibrary.Models;

namespace VatactLibrary.DataAccess
{
    public class DataManipulation
    {
        /// <summary>
        /// Calculate the Total Minutes for Artcc and Other, also checks to see if they met the required hours.
        /// </summary>
        /// <param name="person">Person Model</param>
        public static void CalculateMinimumHoursRequirement(PersonModel person)
        {
            bool requirementMet;
            double totalArtccMinutes = 0.00;
            double totalOtherMinutes = 0.00;
            List<string> artccCallsigns = person.ArtccCallsigns;
            List<string> otherCallsigns = person.OtherCallsigns;

            if (person.AllCallsigns != null)
            {
                foreach (CallsignModel c in person.AllCallsigns)
                {
                    if (artccCallsigns.Contains(c.Callsign))
                    {
                        totalArtccMinutes += c.MinutesOnCallsign;
                    }
                    else if (otherCallsigns.Contains(c.Callsign))
                    {
                        totalOtherMinutes += c.MinutesOnCallsign;
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
            }

            if ((totalArtccMinutes / 60) >= int.Parse(GlobalConfig.SelectedRequiredHours))
            {
                requirementMet = true;
            }
            else
            {
                requirementMet = false;
            }

            person.TotalArtccMinutes = totalArtccMinutes;
            person.TotalOtherMinutes = totalOtherMinutes;
            person.MetMinReqHours = requirementMet;

        }
    }
}
