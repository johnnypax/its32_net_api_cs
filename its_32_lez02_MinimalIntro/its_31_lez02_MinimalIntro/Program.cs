var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Ciao Giovanni, sono /";
});

app.MapGet("/hello", () =>
{
    return "Ciao Giovanni, sono /hello";
}); 

app.Run();
