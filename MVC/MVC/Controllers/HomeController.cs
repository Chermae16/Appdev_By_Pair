using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult studentProfile()
        {
             Class info = new Class();
            info.FirstName1 = "Chermae";
            info.LastName1 = "Borigas";
            info.MiddleName1 = "Palmes";
            info.Nickname1 = "Emyang";
            info.Suffix1 = "N/A";
            info.Birthday1 = "November 16, 2007";
            info.age1 = 18;
            info.Address1 = "San Andres, Malate Manila";
            info.Religion1 = "Roman Catholic";
            info.ContactNumber1 = "09758568741";
            info.StudentNumber1 = "2025-03026-MN-0";
            info.School1 = "Polytechnic University of the Philippines";
            info.Program1 = "Bachelor of Science in Computer Science";
            info.Year1 = "2nd Year";
            info.Section1 = "BSCS 2-1N";
            info.Hobbies1 = "Binge watching Korean and Chinese Dramas, Obsessing over Kpop Idol Groups, and Sleeping";
            info.FavKpop1 = "AHOF, TREASURE, BABYMONSTER, ALPHA DRIVE ONE ";
            info.FunFact1 = "I can spend hours watching Dramas and Kpop contents without noticing the time.";
            info.Description1 = "I’m a lowkey, indecisive yet dedicated student. Making choices for myself or for others " +
                "is one of my biggest weaknesses.However, once I set a goal, I became determined to achieve it. " +
                "Not only that, I am also someone who is eager to learn. Just like how " +
                "Computer Science was never part of my choices for my College program, yet I continue to strive to " +
                "learn the concepts being taught, adjust to the program and slowly learn to love the it.";


            return View(info);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
