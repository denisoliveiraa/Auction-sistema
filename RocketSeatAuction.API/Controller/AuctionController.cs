using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.UseCase;

namespace RocketSeatAuction.API.Controller;
[Route("api/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCurrentAuctionUsecase()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();
        
        return Ok(result);
    }

}
