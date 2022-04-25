using DepartmentTask.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentTask.Data
{
   public class AppDbContext:DbContext
    {
        //public DbSet<Company> Companies { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SMGVT3T;Database=BP202Blog;Trusted_Connection=TRUE;");
            
        }
    }
}
