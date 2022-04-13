var builder = WebApplication.CreateBuilder(args);

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.InstanceName = "My Redis Instance";
    options.Configuration = "Localhost:6379";
});

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();