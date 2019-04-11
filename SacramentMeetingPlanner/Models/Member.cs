using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Member
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string LastName { get; set; }

        [Display(Name = "Conducting")]
        public bool Bishopric { get; set; }

        //public Assignment Assignments { get; set; }
        //public Speaker Speakers { get; set; }


        public ICollection<Assignment> Assignment { get; set; }
        //public ICollection<Speaker> Speaker { get; set; }

    }
}