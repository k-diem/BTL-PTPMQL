using Microsoft.EntityFrameworkCore;
using LibraryMVC.Models;

namespace LibraryMVC.Data
{
        public class ApplicationDbContext : DbContext
        {
                public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
                { }
                public DbSet<Book> Book { get; set; }
        }
}