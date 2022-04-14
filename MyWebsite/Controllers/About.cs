using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Controllers
{
    public class About : Controller
    {
        //[HttpGet]
        public ActionResult ShowAbout()
        {
            return View();
        }
    }
}
