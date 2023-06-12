using System.Net.Http;
using System.Threading.Tasks;
using RestEase;

namespace TankYouVeryMuch.Tests.Configuration.RestEase.Wot;

[Header("User-Agent", "RestEase")]
public interface ITankYouVeryMuchApi
{
    [Get("Accounts/{username}")]
    Task<HttpResponseMessage> GetPlayer([Path] string username);
}