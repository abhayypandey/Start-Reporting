using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Start_Reporting.Models
{
    public class Start_Reportingv2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Start_Reportingv2Context() : base("name=Start_Reportingv2Context")
        {
        }

        public System.Data.Entity.DbSet<Start_Reporting.Models.SmeItem> SmeItems { get; set; }
    }
}
