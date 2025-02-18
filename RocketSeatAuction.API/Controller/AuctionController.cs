using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.UseCase;
using RocketSeatAuction.API.Enums;
using RocketSeatAuction.API.Entities;
using RocketSeatAuction.API.Filter;

namespace RocketSeatAuction.API.Controller;
[Route("api/[controller]")]
[ApiController]
[ServiceFilter(typeof(AuthenticationUserAttribute))]
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
