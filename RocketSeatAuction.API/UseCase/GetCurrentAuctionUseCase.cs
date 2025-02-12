using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Repositories;
using RocketSeatAuction.API.Entities;



namespace RocketSeatAuction.API.UseCase;

public class GetCurrentAuctionUseCase
{
    public Auction Execute()
    {
        var repository = new RocketseatAuctionDbContext();

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault();
    }
}
