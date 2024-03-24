using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace BookCar.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailSideBarSearchBoxComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
