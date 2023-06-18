using DbProvider.Abstract;

namespace TankYouVeryMuch.Models.Entity;

public class WotPlayerPersonalData : IEntity<string>
{
    public string Id { get; set; }
    public long LastBattleTime { get; set; }
    public int AccountId { get; set; }
    public long CreatedAt { get; set; }
    public long UpdatedAt { get; set; }
    public int GlobalRating { get; set; }
    public int? ClanId { get; set; }
    public string Nickname { get; set; }
    public int LogoutAt { get; set; }
    
    public int TreesCut { get; set; }
    
    public int Spotted { get; set; }
    public int BattlesOnStunningVehicles { get; set; }
    public double AvgDamageBlocked { get; set; }
    public int DirectHitsReceived { get; set; }
    public int ExplosionHits { get; set; }
    public int PiercingsReceived { get; set; }
    public int Piercings { get; set; }
    public int Xp { get; set; }
    public int SurvivedBattles { get; set; }
    public int DroppedCapturePoints { get; set; }
    public int HitsPercents { get; set; }
    public int Battles { get; set; }
    public int DamageReceived { get; set; }
    public double AvgDamageAssisted { get; set; }
    public double AvgDamageAssistedTrack { get; set; }
    public int Frags { get; set; }
    public int StunNumber { get; set; }
    public double AvgDamageAssistedRadio { get; set; }
    public int CapturePoints { get; set; }
    public int StunAssistedDamage { get; set; }
    public int Hits { get; set; }
    public int BattleAvgXp { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int DamageDealt { get; set; }
}