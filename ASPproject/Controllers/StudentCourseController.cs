using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPproject.Data;
using ASPproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPproject.Controllers
{
    public class StudentCourseController : Controller
    {
        private readonly SCIDbContext _dbc = new SCIDbContext();

        public IActionResult AddCourse(int studentId, int courseId)
        {
            //StudentId=1&CourseId=3 

            _dbc.StudentCourses
                .Add(new StudentCourse 
                    { 
                        StudentId = studentId, 
                        CourseId = courseId 
                    });

            _dbc.SaveChanges();

            return RedirectToAction("Edit", "Student", new { id = studentId } );

        }

    }
}
