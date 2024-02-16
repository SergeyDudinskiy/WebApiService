using Microsoft.EntityFrameworkCore;
using WebApiService.Database;
using WebApiService.Mutaties;
using WebApiService.Queries;

var builder = WebApplication.CreateBuilder(args);
//string connection = builder.Configuration.GetConnectionString("DefaultConnection");
//!!!бд генерилась на основе классов. чтобы не захломлять код вставкой тестовых данных перенес бд в папку проекта
string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + "\\Database\\Library.mdf";
builder.Services.AddDbContext<DataDbContext>(options => options.UseSqlServer(connection));
builder.Services.AddGraphQL(SchemaBuilder.New().AddMutationType<Mutation>().AddQueryType<Query>().Create());

var app = builder.Build();
app.MapGraphQL();
app.Run();

