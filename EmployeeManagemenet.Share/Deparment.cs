using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagement.Shared
{
    public class Deparment
    {
        public int DeparmentId { get; set; }
        public string DeparmentName { get; set; }          
        public List<Employee> Employees { get; set; }
    }
}
