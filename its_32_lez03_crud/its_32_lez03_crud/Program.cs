using its_32_lez03_crud.Classi;
using System.Collections;

var builder = WebApplication.CreateBuilder(args);

// Configuro la policy CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyOrigin()   // permette qualsiasi origine
            .AllowAnyMethod()   // permette GET, POST, PUT, DELETE, ecc.
            .AllowAnyHeader();  // permette tutti gli headers
    });
});

var app = builder.Build();

app.UseHttpsRedirection();

List<Studente> lista = new List<Studente>()
{
    new Studente(){ Id = 1, Nome = "Giovanni", Cognome = "Pace", Matricola = "AB12345" },
    new Studente(){ Id = 2, Nome = "Valeria", Cognome = "Verdi", Matricola = "AB12346" },
    new Studente(){ Id = 3, Nome = "Marika", Cognome = "Mariko", Matricola = "AB12347" },
};

app.MapPost("/api/studenti", (Studente stu) =>
{
    stu.Id = lista.Count + 1;

    lista.Add(stu);
    return Results.Ok();
});

app.MapGet("/api/studenti", () =>
{
    return Results.Ok(lista);
});

app.UseCors("AllowAll");

app.Run();