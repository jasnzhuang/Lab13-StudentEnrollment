﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Controllers
{
    public class HomeController : Controller
    {
        // Http Getter
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}
