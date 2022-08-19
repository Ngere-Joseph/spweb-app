using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPWebApplication.Models
{
    public class FAQ
    {
        public int id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
