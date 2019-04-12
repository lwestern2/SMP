using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Sacrament
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Meeting Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yy}")]
        public DateTime MeetingDate { get; set; }

        public string MeetingDateString { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Opening Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string OpeningHymn { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Sacrament Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string IntermediateHymn { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Closing Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string ClosingHymn { get; set; }
    }
}
