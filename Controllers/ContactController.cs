using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{

    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
