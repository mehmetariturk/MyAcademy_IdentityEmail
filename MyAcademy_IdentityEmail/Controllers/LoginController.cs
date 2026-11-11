using Microsoft.AspNetCore.Mvc;

namespace MyAcademy_IdentityEmail.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
