 using System;
using System.Collections.Generic;

namespace SacramentMeetingPlanner.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Bishopric { get; set; }

        //public ICollection<Speaker> Prayer { get; set; }

        public ICollection<Sacrament> Sacrament { get; set; }


    }
}