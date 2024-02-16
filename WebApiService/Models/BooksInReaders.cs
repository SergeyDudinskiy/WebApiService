namespace WebApiService.Models
{
    public class BooksInReaders
    {
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int Id { get; set; }
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int ReaderId { get; set; }      
        public Reader Reader { get; set; }
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int BookId { get; set; }      
        public Book Book { get; set; }    
    }
}
