﻿namespace TraversalCoreProject.CQRS.Results.GuideResults
{
    public class GetAllGuideQueryResult
    {
        public int GuideID { get; set; }
        public string? GuideNAme { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
