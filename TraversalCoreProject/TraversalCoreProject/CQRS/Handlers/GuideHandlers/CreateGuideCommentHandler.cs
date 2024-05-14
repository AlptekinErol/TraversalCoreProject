using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using TraversalCoreProject.CQRS.Commands.GuideCommands;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommentHandler:IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommentHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken) // burada ki unit = void demek .net için
        {
            _context.Guides.Add(new Guide // burada new kullanmamızın sebebi parametre olarak methoda guide giremedik ,
                                          // method içerisinde newleyerek guide entitysine ulaşabildik , create ettik?
            {
                GuideNAme= request.GuideNAme,
                Description= request.Description,
                Status=true
            });
            await _context.SaveChangesAsync(); // method async olduğu için async saveledik.
            return Unit.Value; // void'den tek farkı return Unit.Value yazılması zorunlu
        }
    }
}
