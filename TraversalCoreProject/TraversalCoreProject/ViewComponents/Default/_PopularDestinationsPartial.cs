using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinationsPartial:ViewComponent
    {
        DestinationManager destinationsManager = new DestinationManager(
                                               new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationsManager.TGetList();
            return View(values);
        }
    }
}
