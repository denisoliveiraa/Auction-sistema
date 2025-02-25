using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Repositories;
using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.Repositories.DataAccess;

public class OfferRepositiry : IOfferRepository
{

    private readonly RocketseatAuctionDbContext _dbConttext;

    public OfferRepositiry(RocketseatAuctionDbContext dbContext) => _dbConttext = dbContext;


    public void Add(Offer offer)
    {
        _dbConttext.Offers.Add(offer);

        _dbConttext.SaveChanges();
    }
}
