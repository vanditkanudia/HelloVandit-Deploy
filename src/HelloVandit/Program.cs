var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => Results.Text("Hello Vandit"));
app.Run();
