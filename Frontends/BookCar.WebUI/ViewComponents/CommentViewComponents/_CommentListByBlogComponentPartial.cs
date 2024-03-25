using Microsoft.AspNetCore.Mvc;

namespace BookCar.WebUI.ViewComponents.CommentViewComponents
{
    public class _CommentListByBlogComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
