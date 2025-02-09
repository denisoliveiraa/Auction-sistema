using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.UseCase;
using RocketSeatAuction.API.Enums;
using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.Controller;
[Route("api/[controller]")]
[ApiController]
public class AuctionController : BaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuctionUsecase()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();


        if (result is null)
            return NoContent();

        return Ok(result);
    }

  

}
