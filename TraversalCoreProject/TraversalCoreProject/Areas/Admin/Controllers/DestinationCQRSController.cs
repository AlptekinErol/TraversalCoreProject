using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;
using TraversalCoreProject.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler; //Handler class doing the crud or read operations
        private readonly GetDestinationByIDQueryHandler _getDestinationByIDQueryHandler; //Handler class doing the crud or read operations
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler; // handler class is doing the create operation
        private readonly RemoveDestinationHandler _removeDestinationHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;


        public DestinationCQRSController(GetAllDestinationQueryHandler getAllDestinationQueryHandler,
                                         GetDestinationByIDQueryHandler getDestinationByIDQueryHandler,
                                         CreateDestinationCommandHandler createDestinationCommandHandler,
                                           RemoveDestinationHandler removeDestinationHandler,
                                           UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
            _getDestinationByIDQueryHandler = getDestinationByIDQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationHandler = removeDestinationHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult GetDestination(int id) // get destination by id...
        {
            var values = _getDestinationByIDQueryHandler.Handle(new GetDestinationByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command) // Command classes keeping the selected entities that we wwant to create
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
