using Microsoft.EntityFrameworkCore;
using IceTask3.Models;
using System.Collections.Generic;

namespace IceTask3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
