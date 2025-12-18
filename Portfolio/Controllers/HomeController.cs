using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.ViewModels;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

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
            Age = 24,
            Birthdate = "20/12/2001",
            Aboutme = "I am a fresh graduate from the Faculty of Engineering, Tanta University, with a degree in Computer Engineering and Automatic Control and a strong focus on Software Engineering. I specialize in Backend Development, with solid proficiency in ASP.NET Core and C#.",
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

                Links = new List<string>() 
                {
                    "https://github.com/Adel627 ",
                    "https://www.linkedin.com/in/adel-fayed-b976982b0?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app" ,
                    "https://www.facebook.com/adel.fayed.779/?locale=ar_AR",
                    "https://www.instagram.com/adel_gamall_fayed/",
                }
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
                Links = new List<string>() 
                {
                    "https://github.com/Adel627 ",
                    "https://www.linkedin.com/in/adel-fayed-b976982b0?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app" ,
                    "https://www.facebook.com/adel.fayed.779/?locale=ar_AR",
                    "https://www.instagram.com/adel_gamall_fayed/",
                }
            };
          

            return View(persiViewModel);
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
