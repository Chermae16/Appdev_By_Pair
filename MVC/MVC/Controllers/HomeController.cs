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
            Class student = new Class();
            student.FirstName = "Francis Earl";
            student.LastName = "Fernandez";
            student.MiddleName = "Montes";
            student.Nickname = "Francyy";
            student.Age = 22;

            student.Residence = "Ph 4, Blk 12, St.13, Pacita Complex, Pacita, Laguna";
            student.PhoneNumber = "09622934865";
            student.MothersName = "Mirriam Montes Fernandez";
            student.MothersPhoneNumber = "09209735195";

            student.StudentId = "2025-05089-MN-0";
            student.SchoolNameHalf1 = "Polytechnic";
            student.SchoolNameHalf2 = " University of the Philippines";
            student.ProgramHalf1 = "Bachelor of Science";
            student.ProgramHalf2 = " in Computer Science";
            student.YearLevel = "2nd Year";
            student.Section = "2-1N";

            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}