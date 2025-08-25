var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.Use(async (context, next) =>
{
    var logger = app.Logger;

    logger.LogWarning("MIDDLEWARE 1: Prima dell'invocazione di next");
    await next.Invoke();
    logger.LogWarning("MIDDLEWARE 1: Dopo dell'invocazione di next");
});

app.Use(async (context, next) =>
{
    var logger = app.Logger;

    logger.LogWarning("MIDDLEWARE 2: Prima dell'invocazione di next");
    await next.Invoke();
    logger.LogWarning("MIDDLEWARE 2: Dopo dell'invocazione di next");
});

app.MapGet("/primo", () =>
{
    var logger = app.Logger;
    logger.LogInformation("Invocato /primo");

    return "Sono l'endpoint /primo";
});

app.MapGet("/secondo", () =>
{
    var logger = app.Logger;
    logger.LogInformation("Invocato /secondo");

    return "Sono l'endpoint /secondo";
});

app.Run();
