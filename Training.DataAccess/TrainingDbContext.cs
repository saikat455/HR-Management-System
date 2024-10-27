using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainingtask.Models.Entity;

namespace Training.DataAccess
{
    public class TrainingDbContext : DbContext

    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options) : base(options)
        {

        }
        public DbSet<Department>Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Designation> Designations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Desig) // Employee has one Designation
                .WithMany(d => d.Employees) // Designation has many Employees
                .HasForeignKey(e => e.DesigId) // Foreign key in Employee
                .OnDelete(DeleteBehavior.Cascade); // Optional: defines delete behavior
        }

    }
}
