using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query) // int id parametresini tutan sınıftan nesne ürettik ( yani idye ulaştık)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult // bu sınıf ise bizim istediğimiz verileri tutan entity diyebiliriz.
            {
                DestinationId = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight,
                Price = values.Price
            };
        }
        
    }
}
