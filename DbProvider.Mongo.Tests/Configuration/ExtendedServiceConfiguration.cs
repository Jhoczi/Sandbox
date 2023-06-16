using DbProvider.Mongo.Abstract;
using Microsoft.Extensions.Configuration;

namespace DbProvider.Mongo.Tests.Configuration;

public class ServiceConfiguration : IMongoProviderSettings
{
    public Dictionary<string, string> DatabaseNames { get; set; }
    public Dictionary<string, string> ConnectionStrings { get; set; }

    public ServiceConfiguration(IConfiguration configuration)
    {
        configuration.Bind(this);
    }
}