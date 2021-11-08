using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoJp.Server.Controllers
{
    public class TekstController : Controller
    {
        [Route("tekst1")]
        public IActionResult Tekst1()
        {
            return View();
        }

        [Route("tekst2")]
        public IActionResult Tekst2()
        {
            return View();
        }
    }
}
