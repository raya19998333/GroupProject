using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class StudentCourse
    {
        // this id a forinKey of class Student....

        [ForeignKey(nameof(student))]
        public Student student { get; set; }
        public int StudentID { get; set; }
        public ICollection<Student> students { get; set; } = new HashSet<Student>();




        // this id a forinKey of class Course....
        [ForeignKey(nameof(course))]
        public Course course { get; set; }
        public int CourseID { get; set; }
        public ICollection<Course> courses { get; set; } = new HashSet<Course>();
    }
}
