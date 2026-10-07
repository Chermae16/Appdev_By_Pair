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
             Class info = new Class();
            info.FirstName = "Chermae";
            info.LastName = "Borigas";
            info.MiddleName = "Palmes";
            info.Nickname = "Emyang";
            info.Suffix = "N/A";
            info.Birthday = "November 16, 2007";
            info.age = 18;
            info.Address = "San Andres, Malate Manila";
            info.Religion = "Roman Catholic";
            info.ContactNumber = "09758568741";
            info.StudentNumber = "2025-03026-MN-0";
            info.School = "Polytechnic University of the Philippines";
            info.Program = "Bachelor of Science in Computer Science";
            info.Year = "2nd Year";
            info.Section = "BSCS 2-1N";
            info.Hobbies = "Binge watching Korean and Chinese Dramas, Obsessing over Kpop Idol Groups, and Sleeping";
            info.FavKpop = "AHOF, TREASURE, BABYMONSTER, ALPHA DRIVE ONE ";
            info.FunFact = "I can spend hours watching Dramas and Kpop contents without noticing the time.";
            info.Description = "I’m a lowkey, indecisive yet dedicated student. Making choices for myself or for others " +
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
