using Microsoft.AspNetCore.Mvc;

namespace akademiq_portfolyo.ViewComponents;

public class SkillViewComponent :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
