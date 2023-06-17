using DbProvider.Mongo.Tests.Fixtures;

namespace DbProvider.Mongo.Tests.Tests;

public class DbProviderMongoTests : TestBaseFixture
{
    public DbProviderMongoTests()
    {
        Task.Run(async () => await ClearDatabase());
    }

    // todo : When I implement bulk write operatrions add test cases here XD
}