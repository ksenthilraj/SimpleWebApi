var builder = WebApplication.CreateBuilder(args);

// Enable Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger UI in Development
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/api/hello", () =>
{
    return "Hello from GitHub Actions + Azure!";
});

app.Run();
