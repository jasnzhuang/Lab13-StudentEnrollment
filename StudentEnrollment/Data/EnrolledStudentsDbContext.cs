using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Data
{
    public class EnrolledStudentsDbContext : DbContext
    {
        public EnrolledStudentsDbContext(DbContextOptions<EnrolledStudentsDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
