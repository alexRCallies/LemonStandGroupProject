using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollectionApp.Models;

namespace TrashCollectionApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" });
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole { Name = "Employee", NormalizedName = "EMPLOYEE" });
        }
        public DbSet<Employee> employees { get; set; }
       public DbSet<Customer> customers { get; set; }
       public DbSet<Admin> Admin { get; set; }
    }
}
