using its_32_05_SqlLite;
using its_32_05_SqlLite.Classi;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AutomobileDbContext>(
    options => options.UseSqlite("Data Source=garage.db"));

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/api/automobili", async (AutomobileDbContext db) =>
    await db.Automobiles.ToListAsync());

app.MapPost("/api/automobili", (Automobile auto, AutomobileDbContext db) =>
{
    db.Automobiles.Add(auto);
    db.SaveChanges();
    return Results.Created();
});

app.Run();