using DbProvider.Abstract;

namespace TankYouVeryMuch.Domain.Repositories;

public interface IWotRepository
{
    Task<Models.Entity.WotPlayerPersonalData> CreatePlayerPersonalData(Models.Dto.WotDto.WotAccountStatistics model);
    Task<Models.Entity.WotPlayerPersonalData> UpdatePlayerPersonalData(Models.Dto.WotDto.WotAccountStatistics model);
    Task<Models.Entity.WotPlayerPersonalData> GetPlayerPersonalData(int accountId);
    Task<IDeleteResult> DeletePlayerPersonalData(int accountId);
}