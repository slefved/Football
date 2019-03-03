using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football.WebDevExpress.ModelView
{
    public class PlayerModelView
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public short? Height { get; set; }
        public decimal? AnnualSalary { get; set; }
    }
}