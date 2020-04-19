namespace csharp_dotnetcore_projects.Models
{
    public class Task
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Todo - In-Progress - Testing - Closed
        public string State { get; set; }
        public string Owner { get; set; }
        public string CreatedDate { get; set; }
    }
}
