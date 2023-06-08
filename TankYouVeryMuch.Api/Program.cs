using TankYouVeryMuch.Domain.Services.WotService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("WorldOfTanksApi", config =>
{
    config.BaseAddress = new Uri("https://api.worldoftanks.eu/wot/");
});

builder.Services.AddTransient<IWotService, WotService>();

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

app.Run();