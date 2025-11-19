using Microsoft.AspNetCore.Mvc;

namespace akademiq_portfolyo.Controllers
{
    public class Layout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
