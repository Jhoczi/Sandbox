using System.Text.Json.Serialization;

namespace TankYouVeryMuch.Models.Dto.WotDto;

public class WotDetailedAccountStatistics
{
    public WotBattleStats All { get; set; }
    [JsonPropertyName("trees_cut")]
    public int TreesCut { get; set; }
}