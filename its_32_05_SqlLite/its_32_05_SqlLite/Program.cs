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
{
    var risultato = await db.Automobiles.ToListAsync();
    return risultato;
});

app.MapPost("/api/automobili", (Automobile auto, AutomobileDbContext db) =>
{
    db.Automobiles.Add(auto);
    db.SaveChanges();
    return Results.Created();
});

app.MapGet("/api/utenti", async (AutomobileDbContext db) =>
    await db.Utentes.ToListAsync());

app.MapPost("/api/utenti", (Utente ute, AutomobileDbContext db) =>
{
    db.Utentes.Add(ute);
    db.SaveChanges();
    return Results.Created();
});

app.Run();