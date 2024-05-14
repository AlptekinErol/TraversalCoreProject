using DocumentFormat.OpenXml.VariantTypes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.CQRS.Commands.GuideCommands;
using TraversalCoreProject.CQRS.Queries.GuideQueries;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
   
    [Area("Admin")]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }

        public async Task<IActionResult> GetGuides(int id)
        {
            var values = await _mediator.Send(new GetGuideByIdQuery(id));  // Query sınıfı bizim parametrelerimizi tuttuğu için id değerini o sınıftan alıyoruz
            return View(values);
        }

        [HttpGet]

        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommand command)  // önceki controller örneklerinde ki gibi parametre olarak entity geçerken burada da bizim eklemek istediğimiz columnlar
                                       //Ayrıca aynı sınıf olması Handler classında yakalanıyor  // CreateGuideCommand class içerisinde olduğu için o classı parametre olarak verdik
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
