using Microsoft.AspNetCore.Components;

namespace RocketSeatAuction.API.Communication.Request;

public class RequestCreateOfferResponse
{
    public decimal Price { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}
