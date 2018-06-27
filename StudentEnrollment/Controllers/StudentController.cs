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
    public class StudentController : Controller
    {
        private EnrolledStudentsDbContext _context;

        public StudentController(EnrolledStudentsDbContext context)
        {
            _context = context;
        }

        // Add a Student to the Database

        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(Student newStudent)
        {
            await _context.Students.AddAsync(newStudent);
            await _context.SaveChangesAsync();

            return RedirectToAction("Student", "CreateStudent");
        }
        
        // Update a Student in the Database

        [HttpGet]
        public async Task<IActionResult> UpdateStudent(int? id)
        {
            if (id.HasValue)
            {
                Student studentToUpdate = await _context.Students.FirstOrDefaultAsync(a => a.ID == id);
                return View(studentToUpdate);
            }

            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]
        //public Task<IActionResult> UpdateStudent(Student updatedStudent)
        //{
        //    _context.Students.Add(updatedStudent);


        //    return View();
        //}

    }
}
