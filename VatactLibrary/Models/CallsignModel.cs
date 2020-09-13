using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatactLibrary.Models
{
    public class CallsignModel
    {
        /// <summary>
        /// Uniqe ID for the Callsign
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Callsign used by the person
        /// </summary>
        public string Callsign { get; set; }

        /// <summary>
        /// Date and Time the person started using the callsign
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Date and Time the person stopped using the callsign
        /// </summary>
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// How lon the person was on the callsign in minutes
        /// </summary>
        public double MinutesOnCallsign { get; set; }
    }
}
