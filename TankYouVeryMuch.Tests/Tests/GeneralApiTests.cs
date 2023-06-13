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
        var accountId = 502466176;

        var getPlayerResult = await _tankYouVeryMuchApi.GetPlayer(username);
        
        getPlayerResult.EnsureSuccessStatusCode();
        getPlayerResult.StatusCode.Should().Be(HttpStatusCode.OK);

        var getPlayerResultData = await getPlayerResult.Content.ReadFromJsonAsync<WotPlayerResponse>();
        getPlayerResultData.Should().NotBeNull();
        getPlayerResultData.Meta.Count.Should().Be(1);
        getPlayerResultData.Status.Should().Be("ok");

        var playerAccountDetails = getPlayerResultData.Data.First();
        playerAccountDetails.AccountId.Should().Be(accountId);
        playerAccountDetails.Nickname.Should().Be(username);
    }
    
    [Fact]
    public async Task GetPlayerPersonalData_Should_ReturnsPlayerInfo_002()
    {
        var username = "KseroPL";
        var accountId = 502466176;

        var getPlayerResult = await _tankYouVeryMuchApi.GetPlayerData(accountId);
        
        getPlayerResult.EnsureSuccessStatusCode();
        getPlayerResult.StatusCode.Should().Be(HttpStatusCode.OK);

        var getPlayerResultData = await getPlayerResult.Content.ReadFromJsonAsync<WotPlayerPersonalDataResponse>();
        getPlayerResultData.Should().NotBeNull();
        getPlayerResultData.Meta.Count.Should().Be(1);
        getPlayerResultData.Status.Should().Be("ok");

        var playerAccountDetails = getPlayerResultData.Data.First();
        playerAccountDetails.Key.Should().Be(accountId.ToString());
        playerAccountDetails.Value.AccountId.Should().Be(accountId);
        playerAccountDetails.Value.Nickname.Should().Be(username);

        var wotDetailedAccountStatistics = playerAccountDetails.Value.WotDetailedAccountStatistics;
        wotDetailedAccountStatistics.TreesCut.Should().NotBe(0);
        wotDetailedAccountStatistics.All.Battles.Should().NotBe(0);
        wotDetailedAccountStatistics.All.Wins.Should().NotBe(0);
        wotDetailedAccountStatistics.All.Losses.Should().NotBe(0);
    }
}