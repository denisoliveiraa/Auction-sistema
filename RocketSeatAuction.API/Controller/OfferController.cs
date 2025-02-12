using RocketSeatAuction.API.Filters;
using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.Communication.Request;
using RocketSeatAuction.API.UseCase.Offers.CreateOffer;

namespace RocketSeatAuction.API.Controller;
[Route("[controller]")]
[ApiController]
[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : BaseController
{
    [HttpPost]
    [Route("{itemId}")]
    
    public IActionResult CreateOffer(
        [FromRoute]int itemId,
        [FromBody]RequestCreateOfferResponse request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);
        return Created(string.Empty, id);
    }
}
