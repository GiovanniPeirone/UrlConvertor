var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "/Your Url");

app.MapGet("/{Url}", () =>
{
    return Url;
});

app.Run();
