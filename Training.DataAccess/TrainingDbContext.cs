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
            // Configure Employee entity
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Desig)
                .WithMany() // If you have a navigation property in Designation for Employees, use it here
                .HasForeignKey(e => e.DesigId)
                .OnDelete(DeleteBehavior.Cascade); // Set the delete behavior as needed


        }
        }
    }
