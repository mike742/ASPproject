using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Models
{
    public class Department
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public List<Employee> Employees { set; get; }
    }
}
