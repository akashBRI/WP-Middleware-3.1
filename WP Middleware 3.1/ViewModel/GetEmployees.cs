using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WP_Middleware.ViewModel
{
    public class Payroll
    {
        public int payRate { get; set; }
        public int overtimePayRate { get; set; }
        public int billRate { get; set; }
        public int overtimeBillRate { get; set; }
    }

    public class BreakTime
    {
        public string type { get; set; }
        public int allowance { get; set; }
        public bool overage { get; set; }
        public bool multipleOverage { get; set; }
    }

    public class Days
    {
        public bool monday { get; set; }
        public bool tuesday { get; set; }
        public bool wednesday { get; set; }
        public bool thursday { get; set; }
        public bool friday { get; set; }
        public bool saturday { get; set; }
        public bool sunday { get; set; }
    }

    public class Privileges
    {
        public bool apps { get; set; }
        public bool productivity { get; set; }
        public bool screenshots { get; set; }
        public string pm { get; set; }
        public bool offline { get; set; }
        public bool manualTime { get; set; }
        public bool manualTimeCreate { get; set; }
    }

    public class Settings
    {
        public string type { get; set; }
        public int idle { get; set; }
        public int breaks { get; set; }
        public BreakTime breakTime { get; set; }
        public int screenshots { get; set; }
        public Days days { get; set; }
        public bool icon { get; set; }
        public Privileges privileges { get; set; }
        public bool timer { get; set; }
        public bool clocker { get; set; }
    }

    public class Employees
    {
        public string id { get; set; }
        public string user { get; set; }
        public string hwid { get; set; }
        public string name { get; set; }
        public string computer { get; set; }
        public string organizationId { get; set; }
        public string identifier { get; set; }
        public string teamId { get; set; }
        public string sharedSettingsId { get; set; }
        public string type { get; set; }
        public List<string> projects { get; set; }
        public object deactivated { get; set; }
        public int invited { get; set; }
        public object createdAt { get; set; }
        public object updatedAt { get; set; }
        public object firstDataAt { get; set; }
        public object aliasId { get; set; }
        public string email { get; set; }
        public Payroll payroll { get; set; }
        public string version { get; set; }
        public string modelName { get; set; }
        public object title { get; set; }
        public Settings settings { get; set; }
    }


}
