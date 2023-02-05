using MentorFrontToBack.Models;
using Microsoft.EntityFrameworkCore;
namespace MentorFrontToBack.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Courses> courses { get; set; }
        public DbSet<Teachers> teachers { get; set; }
        public DbSet<EventsPage> eventsPages { get; set; }
        public DbSet<Pricings> pricings { get; set; }
        public DbSet<AboutPages> aboutpages { get; set; }
        public DbSet<Home> homes { get; set; }
    }
}
