using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.ViewModels;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Personalinfo persi = new Personalinfo()
        {
            Name = "Adel Fayed",
            Title = "Backend .Net Developer",
            Age = 22,
            Birthdate = "20/12/2001",
            Aboutme = "I am Adel Fayed, I am student in Computer Engineering and Automatic Control at Tanta University. I am passionate about backend development,  using .NET technologies. With a strong foundation in software engineering principles and building efficient applications, I am eager to apply my skills and knowledge to real-world projects. ",
            City = "Kafr El Zayat - Tanta - Egypt",
            Phonenumber = "+20 1120443095",
            Email = "fayedadel627@gmail.com"
        };
      


        public IActionResult Index()
        {
            ViewBag.name = "Adel Fayed";
            ViewData["Title"] = "Backend .Net Developer";
            PersonalinfoViewModel persiViewModel = new PersonalinfoViewModel
            {

                Links = new List<string>() { "https://www.linkedin.com/in/adel-fayed-b976982b0?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app" }
            };

            return View(persiViewModel);
        }
        public IActionResult Aboutme()
        {
            
            return View(persi);
        }

        public IActionResult Skills()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult Contactme()
        {
            PersonalinfoViewModel persiViewModel = new PersonalinfoViewModel
            {
                Info = persi,
                Links = new List<string>() { "https://www.linkedin.com/in/adel-fayed-b976982b0?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app" }
            };
            Contactmessage x = new Contactmessage();

            return View(x);
        }

        [HttpPost]
        public IActionResult Contacts(Contactmessage model) 
        {
            return RedirectToAction("Index");                  
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
