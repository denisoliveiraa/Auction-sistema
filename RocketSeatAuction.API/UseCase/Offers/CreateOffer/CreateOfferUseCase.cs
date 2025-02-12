using RocketseatAuction.API.Repositories;
using RocketSeatAuction.API.Communication.Request;
using RocketSeatAuction.API.Entities;
using RocketSeatAuction.API.Services;

namespace RocketSeatAuction.API.UseCase.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;

    public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;
  

    public int Execute(int itemId, RequestCreateOfferResponse request)
    {
        var repository = new RocketseatAuctionDbContext();

        var user =  _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id,
        };

        repository.Offers.Add(offer);

        repository.SaveChanges();

        return offer.Id;
    }
}
