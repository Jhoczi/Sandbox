using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
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

    public async Task<WotPlayerPersonalDataResponse> GetPlayerPersonalData(int accountId)
    {
        var client = _clientFactory.CreateClient("WorldOfTanksApi");
        var response = await client.GetAsync($"account/info/?application_id={_applicationId}&account_id={accountId}");
        
        response.EnsureSuccessStatusCode();

        var jsonSettings = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        };
        
        var responseResult = await response.Content.ReadFromJsonAsync<WotPlayerPersonalDataResponse>(jsonSettings);

        return responseResult;
    }
}