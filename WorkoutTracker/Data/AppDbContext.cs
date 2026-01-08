using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WorkoutTracker.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //create environment variable ConnectionStrings__DefaultConnection or use user secrets
            //set Server= (ex.localhost), Port= (ex.5432), Database= (ex.workouttrackerdb), User Id= (ex.postgres), Password= (ex.yourpassword)
            

            // If the DbContext was already configured in Program.cs, do nothing.
            if (optionsBuilder.IsConfigured)
            {
                return;
            }

            var conn = Configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrWhiteSpace(conn))
            {
                throw new InvalidOperationException(
                    "Connection string 'DefaultConnection' was not found. " +
                    "Add it to appsettings.json or set the environment variable ConnectionStrings__DefaultConnection.");
            }

            optionsBuilder.UseNpgsql(conn);
        }

        public DbSet<Models.WorkoutModel> Workouts { get; set; }
        public DbSet<Models.CreateAccountModel> Users { get; set; }
    }
}
