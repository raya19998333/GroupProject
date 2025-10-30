using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Titel { get; set; }
        public string Category { get; set; }
        public string Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Fee { get; set; }
        public Course course { get; set; }


        [ForeignKey(nameof(triainer))]
        public Triainer triainer { get; set; }
        public int TrainerID { get; set; }

        public ICollection<Triainer>triainers { get; set; } = new HashSet<Triainer>();

    }
}
