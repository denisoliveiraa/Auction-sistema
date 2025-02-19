using RocketseatAuction.API.Repositories;

namespace RocketSeatAuction.API.Repositories.DataAccess;

public class AuctionRepository
{
    private readonly RocketseatAuctionDbContext _dbContext;
    public AuctionRepository(RocketseatAuctionDbContext dbContext)
    {

    }
}
