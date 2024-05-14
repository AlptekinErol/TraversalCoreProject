namespace TraversalCoreProject.CQRS.Results.GuideResults
{
    public class GetGuideByIdQueryResult // bu class tüm guide proplarını tutmak zorunda değil hangi columnlar lazımsa onları propluyoruz
    {
        public int GuideID { get; set; }
        public string? GuideNAme { get; set; }
        public string? Description { get; set; }
    }
}
