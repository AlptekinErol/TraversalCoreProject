using MediatR;

namespace TraversalCoreProject.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand:IRequest
    {
        public string? GuideNAme { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool Status { get; set; }
    }
}
