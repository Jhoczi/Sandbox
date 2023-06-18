using DbProvider.Mongo.Abstract;

namespace TankYouVeryMuch.Api.Configuration;

public class ServiceConfiguration : IMongoProviderSettings
{
    private Dictionary<string, string> Settings { get; set; }
    public Dictionary<string, string> DatabaseNames { get; set; }
    public Dictionary<string, string> ConnectionStrings { get; set; }

    public ServiceConfiguration(IConfiguration configuration)
    {
        configuration.Bind(this);
    }

    
}