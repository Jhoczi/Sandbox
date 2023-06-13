using System.Net.Http;
using System.Threading.Tasks;
using RestEase;

namespace TankYouVeryMuch.Tests.Configuration.RestEase.Wot;

[Header("User-Agent", "RestEase")]
public interface ITankYouVeryMuchApi
{
    [Get("Accounts/player")]
    Task<HttpResponseMessage> GetPlayer([Query] string username);
    
    [Get("Accounts/playerAccountData")]
    Task<HttpResponseMessage> GetPlayerData([Query] int accountId);
}