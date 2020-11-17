using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Models
{
    public class Instructor
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }

        [ForeignKey("CourseId")]
        public Course Course { set; get; }
    }
}
