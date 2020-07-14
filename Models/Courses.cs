using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Models
{
    public class Courses
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        //[ForeignKey("User")]
        //public int Id { get; set; }
        //public ICollection<User> Users { get; set; }

    }
}
