using System.Text.Json.Serialization;

namespace TankYouVeryMuch.Models.Dto.WotDto;

public class WotPlayerInfo
{
    [JsonPropertyName("account_id")]
    public int AccountId { get; init; }
    public string Nickname { get; init; }
}