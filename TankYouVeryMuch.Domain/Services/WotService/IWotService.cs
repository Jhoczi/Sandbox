using TankYouVeryMuch.Models.Dto.WotDto;

namespace TankYouVeryMuch.Domain.Services.WotService;

public interface IWotService
{
    Task<WotPlayerResponse> GetPlayer(string username);
    
    // todo: implement this after GetPlayer
    //Task<object> GetPlayerDetails(string accountId);
}