using Microsoft.Extensions.Configuration;

namespace DbProvider.Mongo.Tests.Configuration;

public static class TestConfigurationExtensions
{
    public static IConfigurationRoot CreateBuilderRoot()
    {
        var basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;
        var cfgBuilder = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json");
        var root = cfgBuilder.Build();
        return root;
    }
}