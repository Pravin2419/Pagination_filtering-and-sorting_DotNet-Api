using Microsoft.EntityFrameworkCore;
using Pagination_filtering_and_sorting.Models;
using Pagination_filtering_and_sorting.Repository;
using Pagination_filtering_and_sorting.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetService<IConfiguration>();
builder.Services.AddDbContext<demoprojectContext>(item => item.UseSqlServer(config.GetConnectionString("Mycon")));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IuserRepository, UserRepository>();  

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

app.Run();
