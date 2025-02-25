using RocketSeatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}