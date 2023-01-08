using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Module4_HW4.Configurations;
using Module4_HW4.Models;

namespace Module4_HW4
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(
                new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(
                new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(
                new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(
                new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(
                new TitleConfiguration());
        }
    }
}
