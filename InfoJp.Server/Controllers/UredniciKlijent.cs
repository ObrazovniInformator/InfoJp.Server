using InfoJp.Server.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoJp.Server.Controllers
{
    public class UredniciKlijent : Controller
    {
        InfoJPContext _context = new InfoJPContext();

        [Route("oblastiUrednici")]
        public IActionResult Index()
        {
            List<Urednici> urednici = _context.Urednicis.ToList();
            return View(urednici);
        }

        [Route("biografija/{id}")]
        public IActionResult Biografija(int id)
        {
            Urednici urednik = _context.Urednicis.Find(id);
            urednik.Biografija = urednik.Biografija.Replace("\r\n", "<br>");
            return View(urednik);
        }
    }
}
