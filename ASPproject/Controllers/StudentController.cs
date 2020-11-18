using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPproject.Data;
using ASPproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPproject.Controllers
{
    public class StudentController : Controller
    {
        private readonly SCIDbContext _dbc = new SCIDbContext();
        public IActionResult Index()
        {
            List<Student> students = _dbc.Students.ToList();

            return View(students);
        }

        public IActionResult Details(int id)
        {
            Student student = _dbc.Students.Where(s => s.Id == id).FirstOrDefault();

            List<Course> courses = _dbc.StudentCourses
                .Where(sc => sc.StudentId == id)
                .Select(c => c.Course)
                .ToList();

            ViewBag.Courses = courses;

            return View(student);
        }

        public IActionResult Edit(int id)
        {
            Student student = _dbc.Students.Where(s => s.Id == id).FirstOrDefault();

            List<Course> courses = _dbc.StudentCourses
                .Where(sc => sc.StudentId == id)
                .Select(c => c.Course)
                .ToList();

            ViewBag.Courses = courses;

            ViewBag.AvailableCourses = _dbc.Courses
                .Except(courses)
                .ToList();

            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
