using Autofac;
using DbProvider.Mongo.Abstract;
using DbProvider.Mongo.Configuration;
using DbProvider.Mongo.Tests.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DbProvider.Mongo.Tests.Configuration;

public static class DIContainerHelper
{
    public static IContainer CreateDIContainer()
    {
        IConfigurationRoot configuration = TestConfigurationExtensions.CreateBuilderRoot();
    
        var builder = new ContainerBuilder();

        builder.RegisterInstance(new ServiceConfiguration(configuration)).SingleInstance();
        builder.Register(c => c.Resolve<ServiceConfiguration>()).As<IMongoProviderSettings>().SingleInstance();
        builder.RegisterType<MongoProviderSettings>().SingleInstance();
        builder.Register(c => new MongoClient(c.Resolve<MongoProviderSettings>().ConnectionStrings.First().Value))
            .As<IMongoClient>().SingleInstance();
        builder.RegisterType<MongoProvider<DummyModel>>().As<IMongoProvider<DummyModel>>()
            .WithParameter("databaseName","MongoProviderTests" ).SingleInstance();
        
        return builder.Build();    
    }
}