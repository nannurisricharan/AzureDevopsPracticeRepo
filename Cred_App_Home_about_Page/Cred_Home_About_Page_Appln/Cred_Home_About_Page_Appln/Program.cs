var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    await context.Response.SendFileAsync("landshomepage.html");
});

app.MapGet("/landshomepage.html", async context =>
{
    await context.Response.SendFileAsync("landshomepage.html");
});

// Map About page
app.MapGet("/landsaboutpage.html", async context =>
{
    await context.Response.SendFileAsync("landsaboutpage.html");
});


app.Run();
