using Microsoft.EntityFrameworkCore;

namespace csharp_dotnetcore_projects.Models
{

    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            :base(options)
        {

        }

        public DbSet<Project> Projects { get; set;}

        public DbSet<Task> Tasks { get; set; }
    }
}
