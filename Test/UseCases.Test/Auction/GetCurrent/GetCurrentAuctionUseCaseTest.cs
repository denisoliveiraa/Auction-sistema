using FluentAssertions;
using Moq;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace UseCases.Test.Auction.GetCurrent;
public  class GetCurrentAuctionUseCaseTest
{
    [Fact]  
    public void Sucess()
    {

        var mock = new Mock<IAuctionRepository>

        var useCase = new GetCurrentAuctionUseCase(null);

        var auction = useCase.Execute();


        auction.Should().NotBeNull();
    }
}
