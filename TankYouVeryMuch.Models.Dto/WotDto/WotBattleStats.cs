using System.Text.Json.Serialization;

namespace TankYouVeryMuch.Models.Dto.WotDto;

public class WotBattleStats
{
    public int Spotted { get; set; }
    [JsonPropertyName("battles_on_stunning_vehicles")]
    public int BattlesOnStunningVehicles { get; set; }
    [JsonPropertyName("avg_damage_blocked")]
    public double AvgDamageBlocked { get; set; }
    [JsonPropertyName("direct_hits_received")]
    public int DirectHitsReceived { get; set; }
    public int ExplosionHits { get; set; }
    [JsonPropertyName("piercings_received")]
    public int PiercingsReceived { get; set; }
    public int Piercings { get; set; }
    public int Xp { get; set; }
    [JsonPropertyName("survived_battles")]
    public int SurvivedBattles { get; set; }
    [JsonPropertyName("dropped_capture_points")]
    public int DroppedCapturePoints { get; set; }
    public int HitsPercents { get; set; }
    public int Battles { get; set; }
    [JsonPropertyName("damage_received")]
    public int DamageReceived { get; set; }
    [JsonPropertyName("avg_damage_assisted")]
    public double AvgDamageAssisted { get; set; }
    [JsonPropertyName("avg_damage_assisted_track")]
    public double AvgDamageAssistedTrack { get; set; }
    public int Frags { get; set; }
    [JsonPropertyName("stun_number")]
    public int StunNumber { get; set; }
    [JsonPropertyName("avg_damage_assisted_radio")]
    public double AvgDamageAssistedRadio { get; set; }
    [JsonPropertyName("capture_points")]
    public int CapturePoints { get; set; }
    [JsonPropertyName("stun_assisted_damage")]
    public int StunAssistedDamage { get; set; }
    public int Hits { get; set; }
    [JsonPropertyName("battle_avg_xp")]
    public int BattleAvgXp { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    [JsonPropertyName("damage_dealt")]
    public int DamageDealt { get; set; }
}