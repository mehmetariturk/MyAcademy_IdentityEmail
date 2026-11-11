using Microsoft.AspNetCore.Mvc;

namespace MyAcademy_IdentityEmail.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }

        public IActionResult Sendbox()
        {
            return View();
        }

        public IActionResult CreateMessage()
        {
            return View();
        }
    }
}
