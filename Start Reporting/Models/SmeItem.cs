using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Start_Reporting.Models;

namespace Start_Reporting.Models
{
    public class SmeItem
    {
        public int Id { get; set; }
        public string HereEmailId { get; set; }

        [EnumDataType(typeof(WorkType)), Display(Name = "Type")]
        [Required]
        public WorkType Work_Type { get; set; }       //Hardcoded Enum

        [EnumDataType(typeof(SubType)), Display(Name = "Sub Type")]
        [Required]
        public SubType Sub_Type { get; set; }          //Hardcoded Enum

        [DataType(DataType.MultilineText)]
        [StringLength(maximumLength: 500), Display(Name = "Description If Any")]
        public string Description { get; set; }

        [Display(Name = "Start Time")]
        [Required]
        public string StartTime { get; set; }

        [Display(Name = "End Time")]
        public string EndTime { get; set; }

        public string TotalElapsedTime { get; set; }
    }
}
