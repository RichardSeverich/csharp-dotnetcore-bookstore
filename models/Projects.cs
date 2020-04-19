namespace csharp_dotnetcore_projects.Models
{

    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Active, Inactive.
        public string State { get; set; }
        public string CreatedDate { get; set; }
    }
}