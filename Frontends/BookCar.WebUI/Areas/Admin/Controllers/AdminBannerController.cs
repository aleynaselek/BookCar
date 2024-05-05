using Microsoft.AspNetCore.Mvc;

namespace BookCar.WebUI.Areas.Admin.Controllers
{
    public class AdminBannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
