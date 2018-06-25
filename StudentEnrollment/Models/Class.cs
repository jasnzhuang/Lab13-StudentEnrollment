using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class Class
    {
        public int ID { get; set; }

        [Required]
        public ClassName ClassName { get; set; }
        public List<Student> Students { get; set; }
    }

    public enum ClassName
    {
        Art,
        Biology,
        Chemistry,
        [Display(Name = "Computer Science")] ComputerScience,
        English,
        History,
        Math,
        Music,
        Physics
    }
}
