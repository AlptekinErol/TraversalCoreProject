namespace TraversalCoreProject.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        // Command class is created for Creating operation ( you can create it for other operations i guess)
        // but these properties are the ones that we want to add ( its not the all entity class ).
        public string? City { get; set; }
        public string? DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
    }
}
