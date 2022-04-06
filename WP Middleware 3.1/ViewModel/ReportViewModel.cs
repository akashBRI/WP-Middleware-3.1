using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WP_Middleware.ViewModel
{
    public class ReportViewModel
    {
        public string TaskName { get; set; }
        public string AssignedTo { get; set; }
        public double ClockIn { get; set; }
        public double ClockOut { get; set; }
        public double TotalTime { get; set; }
        public long TaskCreated { get; set; }
        public long DueDate { get; set; }
        public long PayRate { get; set; }
        public double TimezoneOffset { get; set; }
        public int Count { get; set; }
    }
}
