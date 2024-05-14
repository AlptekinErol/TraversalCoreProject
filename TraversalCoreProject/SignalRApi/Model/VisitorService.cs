using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRApi.DAL;
using SignalRApi.Hubs;
using System.Data;

namespace SignalRApi.Model
{
    public class VisitorService
    {
        private readonly Context _context;
        private readonly IHubContext<VisitorHub> _hubContext;

        public VisitorService(Context context, IHubContext<VisitorHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        public IQueryable<Visitor> GetList()
        {
            return _context.Visitors.AsQueryable();
        }
        public async Task SaveVisitor(Visitor visitor)
        {
            await _context.Visitors.AddAsync(visitor);
            await _context.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("CallVisitorList", "aaa");
        }

        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new List<VisitorChart>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "select * from crosstab('Select Date,City ,CityVisitCounter from Visitors Order By (1,2)') " +
                                                "As ct(VisitDate date , City1 int , City2 int, City3 int,City4 int, City5 int);"; // Postgre Cross table query'si
                command.CommandType = System.Data.CommandType.Text; // oluşturduğumuz command'in türü query => Command.Text = type'ı query demek.
                _context.Database.OpenConnection(); // connectionı açtık yani query ulaşabilir.
                using(var reader= command.ExecuteReader())  // oluşturduğumuz command execute ediliyor
                {
                    while(reader.Read()) // while içerisinde her defasında okurken nyeni bir obje ürettiyor ki 32. satırdaki listeye dolduralım
                    {
                        VisitorChart visitorChart = new VisitorChart(); // 32.Satır List'inin içerisi doluyor tek tek
                        visitorChart.Date = reader.GetDateTime(0).ToShortDateString(); // burayı fazla anlamadım (0) 1. index sonra tek tek artacak ?
                                                                                       // date prop'u doluyor
                        Enumerable.Range(1, 5).ToList().ForEach(x =>
                        {
                            visitorChart.Counts.Add(reader.GetInt32(x));
                        });
                        visitorCharts.Add(visitorChart); // 32. satır listesini iterasyonla tek tek ekliyor 
                    }
                }
                _context.Database.CloseConnection(); // connection kapandı 
                return visitorCharts;
            }
            // Sumamry : anladığım kadarıyla GetInt32-16vs ve GetString GetDate methodları
            // tek başına int parametresi aldığında kendiliğinden iterasyon ediyor. Örn 43 ve 48. satırda 
        }
    }
}
