using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> CreateClasses([Bind("ID, ClassName, StartDate, EndDate, InstructorName")]Class newClass)
        {
            await _context.Classes.AddAsync(newClass);
            await _context.SaveChangesAsync();

            return RedirectToAction("CreateClasses", "Class");
        }

        // Update an Existing Class in the Database

        [HttpGet]
        public async Task<IActionResult> UpdateClasses(int? id)
        {
            if (id.HasValue)
            {
                Class thisClass = await _context.Classes.FirstOrDefaultAsync(c => c.ID == id);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateClasses([Bind("ID, ClassName, StartDate, EndDate, InstructorName")]Class thisClass)
        {
            _context.Classes.Update(thisClass);
            await _context.SaveChangesAsync();

            return View(thisClass);
        }

        // View Details of a Class from the Database

        [HttpGet]
        public async Task<IActionResult> DetailsClasses(int? id)
        {
            if (id.HasValue)
            {
                Class thisClass = await _context.Classes.FirstOrDefaultAsync(c => c.ID == id);
            }

            return View();
        }

        // Delete a Class from the Database

        [HttpGet]
        public async Task<IActionResult> DeleteClasses(int? id)
        {
            if (id.HasValue)
            {
                Class thisClass = await _context.Classes.FirstOrDefaultAsync(c => c.ID == id);
            }

            return View();
        }

        []
    }
}
