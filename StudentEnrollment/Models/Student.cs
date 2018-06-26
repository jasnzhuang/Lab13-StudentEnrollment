using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public GradeYear GradeYear { get; set; }
        [Required]
        public Class Class { get; set;}

        public decimal GPA { get; set; }
    }

    public enum GradeYear
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }
}
