using Microsoft.AspNetCore.Mvc;
//kütüphaneleri çağırıyor

namespace akademiq_portfolyo.Controllers;

public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}




