using Microsoft.EntityFrameworkCore;
using CRUD_image.Models;

namespace CRUD_image.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
