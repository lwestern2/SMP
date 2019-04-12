using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Assignment
    {
        public int ID { get; set; }

        [Display(Name = "Member")]
        public int MemberID { get; set; }

        [Display(Name = "Meeting")]
        public int MeetingID { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Assignment")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string assignment { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Topic { get; set; }

    }
}
