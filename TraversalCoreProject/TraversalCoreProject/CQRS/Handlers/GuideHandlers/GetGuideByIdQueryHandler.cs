using DataAccessLayer.Concrete;
using MediatR;
using NuGet.Protocol.Plugins;
using TraversalCoreProject.CQRS.Queries.GuideQueries;
using TraversalCoreProject.CQRS.Results.GuideResults;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery,   GetGuideByIdQueryResult>
    {//                                Request sınıfı (request için parametre -- Response yani cevap sınıfı(hangi entity?)
     //                                lazım bu parametrenin sınıfı  )        -- 
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                GuideNAme = values.GuideNAme
            };
        }
    }
}
