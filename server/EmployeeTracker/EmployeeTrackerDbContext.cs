using Microsoft.EntityFrameworkCore;
using EmployeeTracker.Models;

namespace EmployeeTracker
{
    public class EmployeeTrackerDbContext : DbContext
    {
        public EmployeeTrackerDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<AboutUs> About { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Roles)
                .WithOne(r => r.Department)
                .HasForeignKey(r => r.DeptId);

            modelBuilder.Entity<Role>()
                .HasMany(r => r.Employees)
                .WithOne(e => e.Role)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Manager)
                .WithMany()
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasMany(m => m.Subordinates)
                .WithOne(e => e.Manager)
                .HasForeignKey(e => e.ManagerId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
