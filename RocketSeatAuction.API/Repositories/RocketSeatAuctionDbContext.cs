﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketSeatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=D:\Workspace\leilaoDbNLW.db");
    }
}
