using Microsoft.EntityFrameworkCore;
using BookManagement.Models;

namespace BookManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options)
        {

        }
    }

}