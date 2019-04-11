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

        public Assignment Assignments { get; set; }
        
        

        public ICollection<Assignment> Assignment { get; set; }
        //public ICollection<Speaker> Speaker { get; set; }

    }
}