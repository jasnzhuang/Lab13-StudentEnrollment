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
        public string Name { get; set; }
        [Required]
        public GradeYear GradeYear { get; set; }
        [Required]
        public Class Class { get; set;}

        public int GPA { get; set; }
    }

    public enum GradeYear
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }
}
