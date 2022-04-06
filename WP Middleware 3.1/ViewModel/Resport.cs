using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WP_Middleware.ViewModel
{
    public class Resport
    {
        public ReportGet ReportGet { get; set; }
        public TaskDetails TaskDetails { get; set; }
        public ProjectDetails ProjectDetails { get; set; }
        public List<EmployeeDate> EmployeeDates { get; set; }
        public ProjectTime ProjectTime { get; set; }

    }
}
