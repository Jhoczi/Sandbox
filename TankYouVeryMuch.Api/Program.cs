using DbProvider.Abstract;
using DbProvider.Mongo;
using DbProvider.Mongo.Abstract;
using DbProvider.Mongo.Configuration;
using MongoDB.Driver;
using TankYouVeryMuch.Api.Configuration;
using TankYouVeryMuch.Domain.Repositories;
using TankYouVeryMuch.Domain.Services.WotService;
using TankYouVeryMuch.Models.Entity;

var builder = WebApplication
    .CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.AddSingleton<ServiceConfiguration>();

builder.Services.AddSingleton<IMongoProviderSettings>(x => x.GetService<ServiceConfiguration>());
builder.Services.AddSingleton<MongoProviderSettings>();
builder.Services.AddSingleton<IMongoClient>(x =>
{
    var mongoSettings = x.GetService<MongoProviderSettings>();
    var mongoClient = new MongoClient(mongoSettings?.ConnectionStrings["Mongo"]);

    return mongoClient;
});
builder.Services.AddSingleton<IDataProvider<WotPlayerPersonalData>, MongoProvider<WotPlayerPersonalData>>(provider =>
    new MongoProvider<WotPlayerPersonalData>(
        provider.GetRequiredService<IMongoClient>(),
        provider.GetService<MongoProviderSettings>()?.DatabaseNames["TankYouVeryMuch"],
        nameof(WotPlayerPersonalData)
    ));


builder.Services.AddSingleton<IWotRepository, WotRepository>();

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