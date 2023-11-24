using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var _allowSpecificOrigins = "CorsPolicy";

builder.Services.AddCors(
    options =>
    {
        options.AddPolicy(
                       name: _allowSpecificOrigins,
                       policy =>
                       {
                          policy
                            .WithOrigins("http://localhost:5500")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                       });
                       
    });


builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.UseCors(_allowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();
