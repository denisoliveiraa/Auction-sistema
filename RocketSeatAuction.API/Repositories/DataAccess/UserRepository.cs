﻿using RocketseatAuction.API.Entities;
using RocketSeatAuction.API.Contracts;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly RocketseatAuctionDbContext _dbContext;
    public UserRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
}