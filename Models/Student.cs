using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public  class Student
    {
        [Key]
        public int StudentID{ get; set; }
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int CivilID { get; set; }
        public DateTime RegistrationData { get; set; }
        public Student student { get; set; }


    }
}
