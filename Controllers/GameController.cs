using Microsoft.AspNetCore.Mvc;
using RuRuServer.Extensions;
using RuRuServer.Models;

namespace RuRuServer.Controllers;

[Route("v2/game")]
[ApiController]
public class GameController : ControllerBase
{
    private readonly ILogger<GameController> _logger;
    private int tokenLength = 40;
    
    public GameController(ILogger<GameController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("list")]
    public ProductResponse ProductList()
    {
        _logger.LogInformation("GameController: product list requested");
        ProductResponse response = new ProductResponse();
        response.ProductList.Add(new ProductItem());
        return response;
    }

    [HttpGet]
    [Route("token/new")]
    public TokenResponse CreateToken()
    {
        _logger.LogInformation("GameController: token requested");
        TokenResponse token = new TokenResponse
        {
            Token = tokenLength.RandomString(),
            ExpiresIn = 1800
        };
        return token;
    }


    [HttpPost]
    [Route("token")]
    public TokenResponse CreateToken(TokenRequest model)
    {
        Console.WriteLine("GameController: token requested");
        TokenResponse token = new TokenResponse
        {
            Token = tokenLength.RandomString(),
            ExpiresIn = 1800
        };
        return token;
    }
}