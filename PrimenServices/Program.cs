

var builder = WebApplication.CreateBuilder();

builder.Services.AddTransient<TimeService>();

var app = builder.Build();  

app.UseMiddleware<TimeMiddleware>();
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Metanit");
});

app.Run();