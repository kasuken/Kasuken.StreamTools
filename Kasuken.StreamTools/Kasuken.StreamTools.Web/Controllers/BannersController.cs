﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kasuken.StreamTools.Web.Controllers
{
    public class BannersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}