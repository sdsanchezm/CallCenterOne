using CallCenterOne;
using CallCenterOne.Data;
using CallCenterOne.Interfaces;
using CallCenterOne.Models;
using CallCenterOne.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// The Design Pattern for the Seed, initially
//builder.Services.AddTransient<Seed>();

builder.Services.AddScoped<ICityService, CityService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlServer<DataContext>(builder.Configuration.GetConnectionString("connString1"));

var app = builder.Build();

// seed the data, the command is "dotnet run initialdata"
if (args.Length == 1 && args[0].ToLower() == "initialdata")
{
    Console.WriteLine("initialdata running...");

    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<Seed>();
        service.SeedData();
    }
}


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
