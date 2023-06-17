using Autofac;
using DbProvider.Mongo.Abstract;
using DbProvider.Mongo.Tests.Configuration;
using DbProvider.Mongo.Tests.Models;

namespace DbProvider.Mongo.Tests.Fixtures;

public class TestBaseFixture
{
    protected readonly IMongoProvider<DummyModel> mongoProvider;

    public TestBaseFixture()
    {
        var container = DIContainerHelper.CreateDIContainer();

        mongoProvider = container.Resolve<IMongoProvider<DummyModel>>();
    }

    protected async Task ClearDatabase()
    {
        await mongoProvider.Delete(_ => true);
    }
}