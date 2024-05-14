using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations?.Count(); // nullable olduğu için ? bıraktım    
            //ViewBag.v2 = c.Guides.Count();  Db boş olduğu için veri boş gelebilir statik giricem
            ViewBag.v2 = "20";
            // client db boş yine statik giriyorum
            ViewBag.v3 = "66";
            // ödüller statik girilebilir
            ViewBag.v4 = "13";
            return View();
        }
    }
}
