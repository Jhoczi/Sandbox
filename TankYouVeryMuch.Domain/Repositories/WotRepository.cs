using DbProvider.Abstract;
using TankYouVeryMuch.Domain.Mappers;
using Entity = TankYouVeryMuch.Models.Entity;
using Dto = TankYouVeryMuch.Models.Dto.WotDto;

namespace TankYouVeryMuch.Domain.Repositories;

public class WotRepository : IWotRepository
{
    private readonly IDataProvider<Entity.WotPlayerPersonalData> _wotDataProvider;

    public WotRepository(IDataProvider<Entity.WotPlayerPersonalData> wotDataProvider)
    {
        _wotDataProvider = wotDataProvider;
    }

    public async Task<Entity.WotPlayerPersonalData> CreatePlayerPersonalData(Dto.WotAccountStatistics model)
    {
        var entity = model.ToEntity();
        
        await _wotDataProvider.Create(entity);

        return entity;
    }

    public async Task<Entity.WotPlayerPersonalData> UpdatePlayerPersonalData(Dto.WotAccountStatistics model)
    {
        var dbEntity = (await _wotDataProvider.Find(x => x.Nickname == model.Nickname || x.AccountId == model.AccountId)).FirstOrDefault();

        if (dbEntity == null)
            throw new InvalidOperationException($"Account {model.AccountId} does not exist in database");

        var updateEntity = model.ToEntity();
        updateEntity.Id = dbEntity.Id;

        await _wotDataProvider.Update(updateEntity);

        return updateEntity;
    }

    public async Task<Entity.WotPlayerPersonalData> GetPlayerPersonalData(int accountId)
    {
        return (await _wotDataProvider.Find(x => x.AccountId == accountId)).FirstOrDefault() ?? throw new Exception("Account not found");
    }

    public async Task<IDeleteResult> DeletePlayerPersonalData(int accountId)
    {
       return await _wotDataProvider.Delete(x => x.AccountId == accountId);
    }
}