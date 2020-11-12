using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPproject.Controllers
{
    public class DepartmentController : Controller
    {
        private EmployeeDbContext _dbc = new EmployeeDbContext();
        public IActionResult Index()
        {
            List<Department> list = _dbc.Departments.ToList(); 
            
            return View(list);
        }
    }
}
