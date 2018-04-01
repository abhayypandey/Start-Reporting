using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Start_Reporting.Models
{
    public class Daily_Attendance
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string HereEmailId { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/yyyy}")]
        public DateTime IDay { get; set; }

        [Required]
        [EnumDataType(typeof(Attendancestatus)), Display(Name = "Status")]
        public Attendancestatus Status { get; set; }          //Hardcoded Enum

        [EnumDataType(typeof(Attendancesubnature)), Display(Name = "Sub Nature")]
        public Attendancesubnature subnature { get; set; }          //Hardcoded Enum

        [EnumDataType(typeof(Attendancenature)), Display(Name = "Nature")]
        public Attendancenature nature { get; set; }          //Hardcoded Enum

        public string UnplannedCount { get; set; }
    }
}