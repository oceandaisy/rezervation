using Microsoft.AspNetCore.Mvc;

namespace rezervation.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
