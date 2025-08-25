var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/primo", () =>
{
    var logger = app.Logger; //Recupero il logger dall'applicazione

    logger.LogInformation("Sono nel primo endpoint"); //Loggo un messaggio di info
    return "Sono il primo";         //Return della RESPONSE
});

app.MapGet("/secondo", () =>
{
    var logger = app.Logger; //Recupero il logger dall'applicazione

    logger.LogWarning("Sono nel secondo endpoint"); //Loggo un messaggio di info
    return "Sono il secondo";
});

app.Run();