using System;
using System.Net.Http;
using RestEase;
using TankYouVeryMuch.Tests.Configuration.RestEase.Wot;

namespace TankYouVeryMuch.Tests.Fixtures;

public class TestBase
{
    protected readonly ITankYouVeryMuchApi _tankYouVeryMuchApi;

    protected TestBase()
    {
        var client = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7026"),
        };
        
        _tankYouVeryMuchApi = RestClient.For<ITankYouVeryMuchApi>(client);
    }
}