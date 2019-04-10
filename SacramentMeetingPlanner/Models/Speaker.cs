using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int ID { get; set; }

        public int MemberID { get; set; }
        public int MeetingID { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Topic { get; set; }

        //public Member Member { get; set; }
        //public Assignment Assignments { get; set; }

    }
}
