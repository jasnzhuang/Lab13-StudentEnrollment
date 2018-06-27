using Microsoft.AspNetCore.Mvc;
using StudentEnrollment.Data;
using StudentEnrollment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Controllers
{
    public class ClassController : Controller
    {
        private EnrolledStudentsDbContext _context;

        public ClassController(EnrolledStudentsDbContext context)
        {
            _context = context;
        }

        // Add a Class to the database

        [HttpGet]
        public IActionResult CreateClasses()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateClasses(Class newClass)
        {
            await _context.Classes.AddAsync(newClass);
            await _context.SaveChangesAsync();

            return RedirectToAction("CreateClasses", "Class");
        }




    }
}
