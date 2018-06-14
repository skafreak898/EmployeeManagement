using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Developer : Employee
    {
        public string DeveloperType { get; set; }
        public string Supervisor { get; set; }
        public string TaxType { get; set; }
    }
}
