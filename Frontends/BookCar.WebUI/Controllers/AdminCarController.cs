using Microsoft.AspNetCore.Mvc;

namespace BookCar.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }
    }
}
