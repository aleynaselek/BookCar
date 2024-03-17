using Microsoft.AspNetCore.Mvc;

namespace BookCar.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _HeadUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
