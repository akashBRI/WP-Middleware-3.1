using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WP_Middleware.ViewModel
{
    public class ProjectDetails
    {
        public string id { get; set; }
        public bool archived { get; set; }
        public List<string> statuses { get; set; }
        public List<string> priorities { get; set; }
        public bool billable { get; set; }
        public Payroll payroll { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<string> employees { get; set; }
        public object deadline { get; set; }
        public string creatorId { get; set; }
        public string organizationId { get; set; }
        public List<string> teams { get; set; }
        public long createdAt { get; set; }
        public long updatedAt { get; set; }
        public string modelName { get; set; }
    }
}
