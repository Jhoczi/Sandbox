using TankYouVeryMuch.Api.Configuration;
using TankYouVeryMuch.Domain.Services.WotService;

var builder = WebApplication
    .CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.AddSingleton<ServiceConfiguration>();
builder.Services.AddTransient<IWotService, WotService>();

builder.Services.AddHttpClient("WorldOfTanksApi", config =>
{
    config.BaseAddress = new Uri(builder.Configuration["Settings:WotApiUrl"] ?? throw new InvalidOperationException());
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();