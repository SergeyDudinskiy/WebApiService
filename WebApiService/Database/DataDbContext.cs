using Microsoft.EntityFrameworkCore;
using WebApiService.Models;

namespace WebApiService.Database
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<BooksInReaders> BooksInReaders { get; set; }
    }
}


