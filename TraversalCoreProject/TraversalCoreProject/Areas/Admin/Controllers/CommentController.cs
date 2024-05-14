using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        //CommentManager _commentManager = new CommentManager(new EfCommentDal());
        // EF bağımlılığını kaldırıyoruz...
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var comments = _commentService.GetCommentsWithDestination();
            return View(comments);
        }
        public IActionResult DeleteComment(int id) 
        {
            var values = _commentService.TGetById(id);
            _commentService.TDelete(values);
            return RedirectToAction("Index");
        }

        
    }
}
