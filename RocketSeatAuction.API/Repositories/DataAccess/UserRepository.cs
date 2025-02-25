using RocketseatAuction.API.Repositories;
using RocketSeatAuction.API.Contracts;

namespace RocketSeatAuction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly RocketseatAuctionDbContext _userRepository;

    private UserRepository(RocketseatAuctionDbContext userRepository)
    {
        _userRepository = userRepository;
    }

    public bool ExistUser


}