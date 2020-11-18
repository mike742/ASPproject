using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPproject.Data;
using ASPproject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPproject.Controllers
{
    public class InstructorController : Controller
    {
        private readonly SCIDbContext _dbc = new SCIDbContext();
        public IActionResult Index()
        {
            List<Instructor> instructors = _dbc
                .Instructors
                .Include("Course")
                .ToList();

            return View(instructors);
        }


        public IActionResult Create()
        {
            // Courses

            return View();
        }
    }
}
