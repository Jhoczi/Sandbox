using System.Text.Json.Serialization;

namespace TankYouVeryMuch.Models.Dto.WotDto;

public class WotAccountStatistics
{
    [JsonPropertyName("last_battle_time")]
    public long LastBattleTime { get; set; }
    [JsonPropertyName("account_id")]
    public int AccountId { get; set; }
    [JsonPropertyName("created_at")]
    public long CreatedAt { get; set; }
    [JsonPropertyName("updated_at")]
    public long UpdatedAt { get; set; }
    [JsonIgnore]
    public object Private { get; set; }
    [JsonPropertyName("global_rating")]
    public int GlobalRating { get; set; }
    [JsonPropertyName("clan_id")]
    public int? ClanId { get; set; }
    public string Nickname { get; set; }
    [JsonPropertyName("logout_at")]
    public int LogoutAt { get; set; }
    [JsonPropertyName("statistics")]
    public WotDetailedAccountStatistics WotDetailedAccountStatistics { get; set; }
}