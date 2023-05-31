using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Data;
using graphqlTest.Data;
using graphqlTest.Repositories;
using graphqlTest.Models;

var builder = WebApplication.CreateBuilder(args);

// // To enable legacy timestamp behavior
// AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register custom services for the superheroes
// builder.Services.AddScoped<ISuperheroRepository, SuperheroRepository>();
// builder.Services.AddScoped<ISuperpowerRepository, SuperpowerRepository>();
// builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddGraphQLServer()
                .AddInMemorySubscriptions()
                .AddInputObjectType<Superhero>()
                .AddQueryType<Query>()
                .AddSubscriptionType<Subscription>()
                .AddMutationType<Mutation>()
                .AddProjections()
                .AddFiltering()
                .AddSorting();

// var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// builder.Services.AddEntityFrameworkNpgsql()
//     .AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseWebSockets();
app.MapGraphQL("/graphql");

app.Run();
