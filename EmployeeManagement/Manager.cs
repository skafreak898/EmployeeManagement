using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Manager : Employee
    {
        public string CostCenter { get; set; }
        public string Supervisor { get; set; }
    }
}
