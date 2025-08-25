using lez04_comunicazioni.Classi;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Sono la rotta /";
});

// https://.../saluta/Giovanni
app.MapGet("/saluta/{nome}", (string nome) =>
{
    return $"Ciao, {nome}";
});

app.MapGet("/saluta/{nome}/{cognome}", (string nome, string cognome) =>
{
    return $"Ciao dal secondo, {nome} {cognome}";
});

app.MapGet("/somma", (int a, int b) =>
{
    return $"La somma di {a} e {b} è uguale a: {a + b}";
});

app.MapGet("/utente/info", () =>
{
    var utente = new Persona() { Cognome = "Rossi", Nome = "Mario", Eta = 30 };   
    return utente;
});

app.MapPost("/utente/inserisci", (Persona per) =>
{
    return $"Utente inserito: {per.Nome} {per.Cognome}, età: {per.Eta}";
});

/*
 * Creare un sistema di gestione utenti che inserisca tutte le nuove persone all'interno di una lista tramite POST. All'inizio la lista è vuota.
 * Creare un endpoint in GET che restituisca tutti gli utenti!
 */

app.Run();