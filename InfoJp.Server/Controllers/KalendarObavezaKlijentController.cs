using InfoJp.Server.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoJp.Server.Controllers
{
    public class KalendarObavezaKlijentController : Controller
    {
        InfoJPContext _context = new InfoJPContext();

        [Route("kalendarObaveza")]
        public IActionResult Index()
        {
            List<KalendarObaveza> obaveze = _context.KalendarObavezas.ToList();
            return View(obaveze);
        }
    }
}
