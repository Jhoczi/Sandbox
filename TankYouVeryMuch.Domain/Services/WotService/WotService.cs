using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;
using TankYouVeryMuch.Models.Dto.WotDto;

namespace TankYouVeryMuch.Domain.Services.WotService;

public class WotService : IWotService
{
    private readonly string _applicationId;
    private readonly IHttpClientFactory _clientFactory;

    public WotService(IHttpClientFactory clientFactory, IConfiguration configuration)
    {
        _clientFactory = clientFactory;
        // INFO: Comes from secret storage
        _applicationId = configuration["WotApplicationId"] ?? throw new InvalidOperationException();
    }
    
    public async Task<WotPlayerResponse> GetPlayer(string username)
    {
        var client = _clientFactory.CreateClient("WorldOfTanksApi");
        var response = await client.GetAsync($"account/list/?application_id={_applicationId}&search={username}");

        response.EnsureSuccessStatusCode();
        var responseResult = await response.Content.ReadFromJsonAsync<WotPlayerResponse>();

        return responseResult;
    }
}