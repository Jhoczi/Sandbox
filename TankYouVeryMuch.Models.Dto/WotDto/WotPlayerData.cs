using System.Text.Json.Serialization;

namespace TankYouVeryMuch.Models.Dto.WotDto;

public class WotPlayerData
{
    [JsonPropertyName("account_id")]
    public int AccountId { get; set; }
    public string Nickname { get; set; }
}