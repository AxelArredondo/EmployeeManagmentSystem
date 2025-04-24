using System;
using Microsoft.EntityFrameworkCore;
using EmployeeManagmentSystem.Models;

namespace EmployeeManagmentSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().ToTable("employees");
        }
    }
}
