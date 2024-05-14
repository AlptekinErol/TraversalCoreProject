using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SubAboutPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SubAboutManager subAboutManager = new SubAboutManager(
                                                 new EfSubAboutDal());
            var values = subAboutManager.TGetList();
            return View(values);
        }
    }
}
