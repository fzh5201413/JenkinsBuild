﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsBuildDemo.Controllers
{
    [Route("[controller]/[action]")]
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}