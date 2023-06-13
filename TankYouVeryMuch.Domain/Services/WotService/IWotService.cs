using TankYouVeryMuch.Models.Dto.WotDto;

namespace TankYouVeryMuch.Domain.Services.WotService;

public interface IWotService
{
    Task<WotPlayerResponse> GetPlayer(string username);
    
    Task<WotPlayerPersonalDataResponse> GetPlayerPersonalData(int accountId);
}