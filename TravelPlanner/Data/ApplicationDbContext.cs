using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelPlanner.Models;

namespace TravelPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<TravelPlanner.Models.Cart>? Cart { get; set; }
        public DbSet<TravelPlanner.Models.Destination>? Destination { get; set; }
        public DbSet<TravelPlanner.Models.Plan>? Plan { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
    }
}