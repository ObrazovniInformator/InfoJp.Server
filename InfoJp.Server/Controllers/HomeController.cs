using InfoJp.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using MailKit.Net.Smtp;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace InfoJp.Server.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public InfoJPContext _context = new InfoJPContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Vesti> vesti = _context.Vestis.OrderByDescending(v => v.Id).ToList();
            ViewBag.Vesti = vesti;
            return View();
        }

        [Route("recUrednika")]
        public IActionResult RecUrednika()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SendMessage(string imeUstanove, string emailUstanove)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Informator JP Gmail", "informatorjp@gmail.com"));
            message.To.Add(new MailboxAddress("Andjelija Mihajlovic", "javnapreduzeca@obrazovni.rs"));
            message.Subject = "Pretpalata na Newslatter sa sajta";
            message.Body = new TextPart("plain")
            {
                Text = "Ime ustanove koja zeli da se prijavi za dobijanje mejlcimpa:" + imeUstanove + ".\n Njihova email adresa: " + emailUstanove
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("informatorjp@gmail.com", "Informator12#");

                client.Send(message);
                client.Disconnect(true);
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
