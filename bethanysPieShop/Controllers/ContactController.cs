using Microsoft.AspNetCore.Mvc;

namespace bethanysPieShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
