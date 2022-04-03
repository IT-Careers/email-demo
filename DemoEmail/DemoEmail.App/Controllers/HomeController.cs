using DemoEmail.App.Models;
using DemoEmail.App.Models.Email;
using DemoEmail.App.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoEmail.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailService emailService;

        public HomeController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Email()
        {
            this.emailService.SendEmail(new Message((new string[]{"atriumandvintrigol@gmail.com"}).ToList(), "Testing Email Service", "PRAKASH PERHUNDE SAYS HI!!!"));

            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}