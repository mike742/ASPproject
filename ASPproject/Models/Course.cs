using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Models
{
    public class Course
    {
        public int Id { set; get; }
        public string Name { set; get; }

        List<Instructor> Instructors { set; get; }
        List<StudentCourse> StudentCourses { set; get; }
    }
}
