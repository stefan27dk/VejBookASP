﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VejBookASP.Controllers
{
    public class HoldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
