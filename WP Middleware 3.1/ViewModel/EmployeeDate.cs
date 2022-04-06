using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WP_Middleware.ViewModel
{
    public class EmployeeDate
    {
        public string id { get; set; }
        public string type { get; set; }
        public string note { get; set; }
        public double start { get; set; }
        public double end { get; set; }
        public double timezoneOffset { get; set; }
        public string shiftId { get; set; }
        public string projectId { get; set; }
        public string taskId { get; set; }
        public bool paid { get; set; }
        public bool billable { get; set; }
        public bool overtime { get; set; }
        public int billRate { get; set; }
        public int overtimeBillRate { get; set; }
        public int payRate { get; set; }
        public int overtimePayRate { get; set; }
        public string taskStatus { get; set; }
        public string taskPriority { get; set; }
        public string user { get; set; }
        public string computer { get; set; }
        public string domain { get; set; }
        public string name { get; set; }
        public string hwid { get; set; }
        public string os { get; set; }
        public string osVersion { get; set; }
        public bool processed { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string employeeId { get; set; }
        public string teamId { get; set; }
        public string sharedSettingsId { get; set; }
        public string organizationId { get; set; }
        public object startTranslated { get; set; }
        public object endTranslated { get; set; }
        public int negativeTime { get; set; }
        public int deletedScreenshots { get; set; }
        public int duration { get; set; }
        public string _index { get; set; }


    }
}
