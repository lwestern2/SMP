using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public int MeetingID { get; set; }
        public string Topic { get; set; }

        public ICollection<Sacrament> Sacrament { get; set; }

    }
}
