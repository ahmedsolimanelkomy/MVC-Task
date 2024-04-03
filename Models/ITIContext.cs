using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Day_2.Models
{
    public class ITIContext : DbContext
    {
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Trainee>? Trainees { get; set; }
        public DbSet<Instructor>? Instructors { get; set; }
        public DbSet<Course>? courses { get; set; }
        public DbSet<crsResult>? CrsResults { get; set; }

        public ITIContext()
        {
            
        }
        public ITIContext(DbContextOptions<ITIContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=./;Initial Catalog = ITIDB;Encrypt=True;Trust Server Certificate=True;")
            .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll)
            .LogTo(log => Debug.WriteLine(log), Microsoft.Extensions.Logging.LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Instructor>().HasQueryFilter(p => !p.IsDeleted);

        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
