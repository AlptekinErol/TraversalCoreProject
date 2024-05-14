using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Mozilla;

namespace TraversalCoreProject.ViewComponents.MemberLayout
{
    public class _MemberLayoutHead:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
