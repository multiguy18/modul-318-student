using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicNavWinForms.Models
{
    class ConnectionEntry
    {

        public string StationFrom { get; set; }

        public string StationTo { get; set; }

        public string DepartureTime { get; set; }

        public string ArrivalTime { get; set; }

        public string Duration { get; set; }

        public string DepartureStation { get; set; }

        public string Direction { get; set; }

        public string ArrivalStation { get; set; }
    }
}
