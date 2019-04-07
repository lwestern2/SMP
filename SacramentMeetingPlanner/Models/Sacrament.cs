using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Sacrament
    {
        public int ID { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingDateString { get; set; }
        public string OpeningHymn { get; set; }
        public string IntermediateHymn { get; set; }
        public string ClosingHymn { get; set; }




    }
}
