using Microsoft.AspNetCore.Mvc;
using TankYouVeryMuch.Domain.Repositories;
using TankYouVeryMuch.Domain.Services.WotService;

namespace TankYouVeryMuch.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IWotService _wotService;
    
    private readonly IWotRepository _wotRepository;

    public AccountsController(IWotService wotService, IWotRepository wotRepository)
    {
        _wotService = wotService;
        _wotRepository = wotRepository;
    }

    [HttpGet("player")]
    public async Task<IActionResult> GetPlayer(string username)
    {
        var player = await _wotService.GetPlayer(username);
        
        return Ok(player);
    }

    [HttpGet("playerData")]
    public async Task<IActionResult> GetPlayerPersonalData(int accountId)
    {
        var playerDetails = await _wotService.GetPlayerPersonalData(accountId);
        
        await _wotRepository.CreatePlayerPersonalData(playerDetails.Data.First().Value);
        
        return Ok(playerDetails);
    }
}