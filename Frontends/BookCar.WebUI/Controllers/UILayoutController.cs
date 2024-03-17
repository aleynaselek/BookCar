using Microsoft.AspNetCore.Mvc;

namespace BookCar.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
