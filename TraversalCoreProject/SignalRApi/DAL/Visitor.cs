namespace SignalRApi.DAL
{

    public enum ECity
    {
        Edirne = 1,
        Ankara = 2,
        Istanbul = 3,
        Antalya = 4,
        Bursa = 5
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCounter { get; set; } // this will going to store the count of the visit for per city 
        public DateTime Date { get; set; }
    }
}
