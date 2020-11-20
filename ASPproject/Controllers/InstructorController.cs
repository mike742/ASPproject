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
            ViewBag.Courses = _dbc.Courses.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Instructor instructor, int courseId)
        {
            instructor.Id = _dbc.Instructors.Last().Id + 1;
            instructor.Course = _dbc.Courses.Find(courseId);

            _dbc.Instructors.Add(instructor);
            _dbc.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Courses = _dbc.Courses.ToList();
            Instructor instructor = _dbc.Instructors
                .Where(i => i.Id == id)
                .FirstOrDefault();

            ViewBag.CourseId = instructor.Course.Id;

            return View(instructor);
        }

    }
}
