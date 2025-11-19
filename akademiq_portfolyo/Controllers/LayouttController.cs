using Microsoft.AspNetCore.Mvc;

namespace akademiq_portfolyo.Controllers
{
    public class LayouttController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
