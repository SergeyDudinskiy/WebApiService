using Microsoft.EntityFrameworkCore;
using WebApiService.Database;
using WebApiService.Models;

namespace WebApiService.Queries
{
    public class Query
    {
        public List<Book> GetBooks([Service] DataDbContext dbContext) => [.. dbContext.Books.Include(x => x.Author)];
        public Book GetBook([Service] DataDbContext dbContext, int id) => dbContext.Books.FirstOrDefault(x => x.Id == id);
        
        public List<Reader> GetReaders([Service] DataDbContext dbContext) => [.. dbContext.Readers.Include(x => x.Lastname)];
        public Reader GetReader([Service] DataDbContext dbContext, int id) => dbContext.Readers.FirstOrDefault(x => x.Id == id);

        public List<BooksInReaders> GetBooksInReaders([Service] DataDbContext dbContext) => [.. dbContext.BooksInReaders.Include(x => x.Id)];
        public BooksInReaders GetBookInReaders([Service] DataDbContext dbContext, int id) => dbContext.BooksInReaders.FirstOrDefault(x => x.Id == id);
    }
}
