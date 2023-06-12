using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;
using TankYouVeryMuch.Models.Dto.WotDto;
using TankYouVeryMuch.Tests.Fixtures;
using Xunit;

namespace TankYouVeryMuch.Tests.Tests;

public class GeneralApiTests : TestBase
{
    [Fact]
    public async Task GetPlayer_Should_ReturnsPlayerInfo_001()
    {
        var username = "KseroPL";

        var getPlayerResult = await _tankYouVeryMuchApi.GetPlayer(username);
        
        getPlayerResult.EnsureSuccessStatusCode();
        getPlayerResult.StatusCode.Should().Be(HttpStatusCode.OK);

        var getPlayerResultData = await getPlayerResult.Content.ReadFromJsonAsync<WotPlayerResponse>();
        getPlayerResultData.Should().NotBeNull();
        getPlayerResultData.Meta.Count.Should().Be(1);
        getPlayerResultData.Status.Should().Be("ok");

        var playerAccountDetails = getPlayerResultData.Data.First();
        playerAccountDetails.AccountId.Should().NotBe(0);
        playerAccountDetails.Nickname.Should().Be(username);
    }
}