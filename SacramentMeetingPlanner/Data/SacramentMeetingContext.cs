using SacramentMeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace SacramentMeetingPlanner.Data
{
    public class SacramentMeetingContext : DbContext
    {
        public SacramentMeetingContext(DbContextOptions<SacramentMeetingContext> options) : base(options)
        {
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Sacrament> Sacrament { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Sacrament>().ToTable("Sacrament");
            modelBuilder.Entity<Assignment>().ToTable("Assignments");

        }
    }
}
