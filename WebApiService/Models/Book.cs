namespace WebApiService.Models
{
    public class Book
    {
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int Id { get; set; }

        [GraphQLNonNullType]
        public string Title { get; set; }
        [GraphQLNonNullType]
        public int Pages { get; set; }
        [GraphQLNonNullType]
        public int Chapters { get; set; }

        [GraphQLNonNullType]
        public Author Author { get; set; }
    }
}
