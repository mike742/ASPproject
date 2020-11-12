using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPproject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPproject.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDbContext _dbc = new EmployeeDbContext();
        public IActionResult Index(int? id)
        {
            List<Employee> list;

            if (id != null)
            {
                list = _dbc.Employees
                    .Include("Department")
                    .Where(e => e.DepartmentId == id)
                    .ToList();
            }
            else
            {
                list = _dbc.Employees
                    .Include("Department")
                    .ToList();
            }
            
            return View(list);
        }
    }
}
