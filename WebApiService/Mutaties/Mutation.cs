using WebApiService.Database;
using WebApiService.Models;

namespace WebApiService.Mutaties
{
    public class Mutation
    {
        public async Task<Book> AddBook([Service] DataDbContext dbContext, string title, int pages, string author, int chapters)
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

        public async Task<Book> DeleteBook([Service] DataDbContext dbContext, int id)
        {
            var book = dbContext.Books.FirstOrDefault(x => x.Id == id);
            
            if (book != null)
            {
                dbContext.Books.Remove(book);
            }

            await dbContext.SaveChangesAsync();
            return null;
        }

        public async Task<Reader> AddReader([Service] DataDbContext dbContext, string firstname, string lastname)
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

        public async Task<Reader> DeleteReader([Service] DataDbContext dbContext, int id)
        {
            var reader = dbContext.Readers.FirstOrDefault(x => x.Id == id);

            if (reader != null)
            {
                dbContext.Readers.Remove(reader);
            }

            await dbContext.SaveChangesAsync();
            return null;
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

        public async Task<BooksInReaders> DeleteBooksInReaders([Service] DataDbContext dbContext, int id)
        {
            var booksInReaders = dbContext.BooksInReaders.FirstOrDefault(x => x.Id == id);

            if (booksInReaders != null)
            {
                dbContext.BooksInReaders.Remove(booksInReaders);
            }

            await dbContext.SaveChangesAsync();
            return null;
        }
    }
}
