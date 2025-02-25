using RocketseatAuction.API.Entities;
using RocketSeatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}