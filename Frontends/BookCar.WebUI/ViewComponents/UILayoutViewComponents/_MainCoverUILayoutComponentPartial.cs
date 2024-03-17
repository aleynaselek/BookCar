using Microsoft.AspNetCore.Mvc;

namespace BookCar.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _MainCoverUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
