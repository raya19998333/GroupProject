using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class StudentTrainer
    {

        // this id a forinKey of class Student....
        [ForeignKey(nameof(student))]
        public Student student { get; set; }
        public int StudentID { get; set; }
        public ICollection<Student> students { get; set; } = new HashSet<Student>();



        // this id a forinKey of class Trainer....
        [ForeignKey(nameof(traininer))]
        public Triainer traininer { get; set; }
        public int TrainerID { get; set; }
        public ICollection<Triainer> triainers { get; set; } = new HashSet<Triainer>();
    }
}
