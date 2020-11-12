using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Models
{
    public class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string City { set; get; }
        public int DepartmentId { set; get; }
        public Department Department { set; get; }
    }
}
