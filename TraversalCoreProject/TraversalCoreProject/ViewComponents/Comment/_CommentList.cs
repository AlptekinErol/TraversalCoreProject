using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Destination
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context _context = new Context();
        public IViewComponentResult Invoke(int id)
        {    
            ViewBag.commentCount= _context.Comments.Where(x=>x.DestinationID==id).Count();
            var values = commentManager.TGetCommentListWithDestinationAndUser(id);
            return View(values);
        }
    }
}
