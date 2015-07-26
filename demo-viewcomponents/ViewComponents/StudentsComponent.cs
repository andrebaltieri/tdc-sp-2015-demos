using Microsoft.AspNet.Mvc;

namespace MvcDi.ViewComponents
{
    public class StudentsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string message)
        {            
            return View(message);
        }
    }
}