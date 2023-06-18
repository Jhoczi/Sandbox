using TankYouVeryMuch.Models.Dto.WotDto;
using TankYouVeryMuch.Models.Entity;
using WotBattleStats = TankYouVeryMuch.Models.Dto.WotDto.WotBattleStats;
using WotDetailedAccountStatistics = TankYouVeryMuch.Models.Dto.WotDto.WotDetailedAccountStatistics;

namespace TankYouVeryMuch.Domain.Mappers;

public static class WotMapper
{
    public static WotPlayerPersonalData ToEntity(this WotAccountStatistics dto)
    {
        var wotBattleStats = dto.WotDetailedAccountStatistics.All;
        
        return new WotPlayerPersonalData()
        {
            LastBattleTime = dto.LastBattleTime,
            AccountId = dto.AccountId,
            CreatedAt = dto.CreatedAt,
            UpdatedAt = dto.UpdatedAt,
            GlobalRating = dto.GlobalRating,
            ClanId = dto.ClanId,
            Nickname = dto.Nickname,
            LogoutAt = dto.LogoutAt,
            
            TreesCut = dto.WotDetailedAccountStatistics.TreesCut,

            Spotted = wotBattleStats.Spotted,
            BattlesOnStunningVehicles = wotBattleStats.BattlesOnStunningVehicles,
            AvgDamageBlocked = wotBattleStats.AvgDamageBlocked,
            DirectHitsReceived = wotBattleStats.DirectHitsReceived,
            ExplosionHits = wotBattleStats.ExplosionHits,
            PiercingsReceived = wotBattleStats.PiercingsReceived,
            Piercings = wotBattleStats.Piercings,
            Xp = wotBattleStats.Xp,
            SurvivedBattles = wotBattleStats.SurvivedBattles,
            DroppedCapturePoints = wotBattleStats.DroppedCapturePoints,
            HitsPercents = wotBattleStats.HitsPercents,
            Battles = wotBattleStats.Battles,
            DamageReceived = wotBattleStats.DamageReceived,
            AvgDamageAssisted = wotBattleStats.AvgDamageAssisted,
            AvgDamageAssistedTrack = wotBattleStats.AvgDamageAssistedTrack,
            Frags = wotBattleStats.Frags,
            StunNumber = wotBattleStats.StunNumber,
            AvgDamageAssistedRadio = wotBattleStats.AvgDamageAssistedRadio,
            CapturePoints = wotBattleStats.CapturePoints,
            StunAssistedDamage = wotBattleStats.StunAssistedDamage,
            Hits = wotBattleStats.Hits,
            BattleAvgXp = wotBattleStats.BattleAvgXp,
            Wins = wotBattleStats.Wins,
            Losses = wotBattleStats.Losses,
            DamageDealt = wotBattleStats.DamageDealt,
        };
    }
    
    public static WotAccountStatistics ToDto(this WotPlayerPersonalData entity)
    {
        return new WotAccountStatistics()
        {
            LastBattleTime = entity.LastBattleTime,
            AccountId = entity.AccountId,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
            GlobalRating = entity.GlobalRating,
            ClanId = entity.ClanId,
            Nickname = entity.Nickname,
            LogoutAt = entity.LogoutAt,
            WotDetailedAccountStatistics = new WotDetailedAccountStatistics
            {
                TreesCut = entity.TreesCut,
                All = new WotBattleStats
                {
                    Spotted = entity.Spotted,
                    BattlesOnStunningVehicles = entity.BattlesOnStunningVehicles,
                    AvgDamageBlocked = entity.AvgDamageBlocked,
                    DirectHitsReceived = entity.DirectHitsReceived,
                    ExplosionHits = entity.ExplosionHits,
                    PiercingsReceived = entity.PiercingsReceived,
                    Piercings = entity.Piercings,
                    Xp = entity.Xp,
                    SurvivedBattles = entity.SurvivedBattles,
                    DroppedCapturePoints = entity.DroppedCapturePoints,
                    HitsPercents = entity.HitsPercents,
                    Battles = entity.Battles,
                    DamageReceived = entity.DamageReceived,
                    AvgDamageAssisted = entity.AvgDamageAssisted,
                    AvgDamageAssistedTrack = entity.AvgDamageAssistedTrack,
                    Frags = entity.Frags,
                    StunNumber = entity.StunNumber,
                    AvgDamageAssistedRadio = entity.AvgDamageAssistedRadio,
                    CapturePoints = entity.CapturePoints,
                    StunAssistedDamage = entity.StunAssistedDamage,
                    Hits = entity.Hits,
                    BattleAvgXp = entity.BattleAvgXp,
                    Wins = entity.Wins,
                    Losses = entity.Losses,
                    DamageDealt = entity.DamageDealt
                }
            }
        };
    }
}