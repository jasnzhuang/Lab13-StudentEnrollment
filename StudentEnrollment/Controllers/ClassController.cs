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

        // Class/*
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /*
         * View Details of a Class from the Database
        */

        // Class/Details/8
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id.HasValue)
            {
                Class thisClass = await _context.Classes.FirstOrDefaultAsync(c => c.ID == id);

                if (thisClass != null)
                {
                    return View(thisClass);
                }
            }

            return RedirectToAction("Index", "Class");
        }

        /*
         * Add a Class to the database
        */

        // Class/Create/
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ID, ClassName, StartDate, EndDate, InstructorName")]Class newClass)
        {
            await _context.Classes.AddAsync(newClass);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Class");
        }

        /*
         * Update an Existing Class in the Database
        */

        // Class/Update/8
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class thisClass = await _context.Classes.FirstOrDefaultAsync(c => c.ID == id);

            return View(thisClass);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, [Bind("StartDate, EndDate, InstructorName")]Class thisClass)
        {
            _context.Classes.Update(thisClass);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Class", thisClass.ID);
        }

        /*
         * Delete a Class from the Database
        */

        // Class/Delete/8
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id.HasValue)
            {
                Class thisClass = await _context.Classes.FirstOrDefaultAsync(c => c.ID == id);
                return View(thisClass);
            }

            return RedirectToAction("Index", "Class");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            Class thisClass = await _context.Classes.FindAsync(id);
            _context.Classes.Remove(thisClass);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Class");
        }


    }
}
