using WebApiService.Database;
using WebApiService.Models;

namespace WebApiService.Mutaties
{
    public class Mutation
    {
        public async Task<Book> Book([Service] DataDbContext dbContext, string title, int pages, string author, int chapters)
        {
            var book = new Book
            {
                Title = title,
                Chapters = chapters,
                Pages = pages,
                Author = new Author { Name = author }
            };

            dbContext.Books.Add(book);
            await dbContext.SaveChangesAsync();
            return book;
        }       

        public async Task<Reader> Reader([Service] DataDbContext dbContext, string firstname, string lastname)
        {
            var reader = new Reader
            {
                Firstname = firstname,
                Lastname = lastname                
            };

            dbContext.Readers.Add(reader);
            await dbContext.SaveChangesAsync();
            return reader;
        }

        public async Task<BooksInReaders> BooksInReaders([Service] DataDbContext dbContext, int readerId, int bookId)
        {
            var booksInReaders = new BooksInReaders
            {
                ReaderId = readerId,
                BookId = bookId
            };

            dbContext.BooksInReaders.Add(booksInReaders);
            await dbContext.SaveChangesAsync();
            return booksInReaders;
        }
    }
}
