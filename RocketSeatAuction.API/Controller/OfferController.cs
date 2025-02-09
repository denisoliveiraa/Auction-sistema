﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.Communication.Request;

namespace RocketSeatAuction.API.Controller;
[Route("[controller]")]
[ApiController]
public class OfferController : BaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute]int itemId, [FromBody]RequestCreateOfferResponse request)
    {
        return Created();
    }
}
