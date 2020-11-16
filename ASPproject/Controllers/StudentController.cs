using ASPproject.Data;
using ASPproject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ASPproject.Controllers
{
    public class StudentController : Controller
    {
        private StudentDbContext _dbc = new StudentDbContext();

        public IActionResult Index()
        {
            List<Student> students = _dbc.Students.ToList();

            return View(students);
        }

        public IActionResult GetDetails(int id)
        {
            Student stEf = _dbc.Students.Where(s => s.Id == id).FirstOrDefault();

            return View(stEf);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = _dbc.Students.Last().Id + 1;
                _dbc.Students.Add(student);
                _dbc.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            Student stEf = _dbc.Students.Where(s => s.Id == id).FirstOrDefault();

            return View(stEf);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            Student st = _dbc.Students.Where(s => s.Id == student.Id).FirstOrDefault();

            if (st != null)
            {
                st.Name = student.Name;
                st.Email = student.Email;

                _dbc.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Student stEf = _dbc.Students.Where(s => s.Id == id).FirstOrDefault();

            return View(stEf);
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            Student stEf = _dbc.Students.Where(s => s.Id == student.Id).FirstOrDefault();
            _dbc.Students.Remove(stEf);
            _dbc.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
