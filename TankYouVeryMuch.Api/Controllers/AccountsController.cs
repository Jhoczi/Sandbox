using Microsoft.AspNetCore.Mvc;
using TankYouVeryMuch.Domain.Services.WotService;

namespace TankYouVeryMuch.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IWotService _wotService;

    public AccountsController(IWotService wotService)
    {
        _wotService = wotService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPlayer(string username)
    {
        var player = await _wotService.GetPlayer(username);
        
        return Ok(player);
    }
}