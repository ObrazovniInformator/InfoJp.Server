using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoJp.Server.Controllers
{
    public class SeminariController : Controller
    {
        [Route("seminari")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
