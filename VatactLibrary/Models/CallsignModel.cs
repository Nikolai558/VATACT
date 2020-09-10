﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatactLibrary.Models
{
    public class CallsignModel
    {
        public int Id { get; set; }
        public string Callsign { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double MinutesOnCallsign { get; set; }
    }
}
