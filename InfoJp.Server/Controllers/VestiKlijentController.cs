using InfoJp.Server.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoJp.Server.Controllers
{
    public class VestiKlijentController : Controller
    {
        InfoJPContext _context = new InfoJPContext();

        [Route("vesti")]
        public IActionResult Index()
        {
            List<Vesti> vesti = _context.Vestis.OrderByDescending(e => e.Id).ToList();
            return View(vesti);
        }

        [Route("vest/{id}")]
        public IActionResult Details(int id)
        {
            Vesti vest = _context.Vestis.Find(id);
            vest.Teskst = vest.Teskst.Replace("\r\n", "<br>");
            return View(vest);
        }
    }
}
