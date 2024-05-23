using Microsoft.EntityFrameworkCore;
using ServiceDemo.Models;
using System.Collections.Generic;

namespace ServiceDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Book> Books { get; set; }

    }
}
