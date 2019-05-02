using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kasuken.StreamTools.Web.Controllers
{
    public class LogosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}