namespace WebApiService.Models
{
    public class Reader
    {
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int Id { get; set; }
        [GraphQLNonNullType]
        public string Firstname { get; set; }
        [GraphQLNonNullType]
        public string Lastname { get; set; }
    }
}
