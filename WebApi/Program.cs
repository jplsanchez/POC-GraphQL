using WebApi.GraphQL;
using WebApi.Repository;
using WebApi.Repository.Implementation;

var builder = WebApplication.CreateBuilder(args);

// GraphQL basic services
builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();

//GraphicQL Authorization
builder.Services.AddAuthentication().Services
                .AddAuthorization(o =>
                    o.AddPolicy("Librarian", p => p.RequireAssertion(_ => false)))
                .AddAuthorization();



builder.Services.AddSingleton<IBookRepository, DumbBookRepository>();
builder.Services.AddSingleton<IAuthorRepository, DumbAuthorRepository>();


var app = builder.Build();

app.UseHttpsRedirection();

//GraphQL
app.MapGraphQL();

app.Run();
