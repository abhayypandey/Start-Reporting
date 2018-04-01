using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Start_Reporting.Models
{
    public enum Attendancesubnature
    {
        //--
        //--
        //--
        //--
        //--
        //--Built 1--15-262--Hard Coded- Do Not Change the Lines
        [Display(Name = "Full Day")]
        Full_Day,
        [Display(Name = "First Half")]
        First_Half,
        [Display(Name = "Second Half")]
        Second_Half
    }
}