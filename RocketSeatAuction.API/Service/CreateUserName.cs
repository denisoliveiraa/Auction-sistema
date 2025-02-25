using RocketSeatAuction.API.Contracts;

namespace RocketSeatAuction.API.Service;

public class CreateUserName : IGetUserName
{
    public string _UserName { get; set; } = string.Empty;

    public CreateUserName(string UserName) => UserName = _UserName;

    public string GetUserName()
    {
        return _UserName;
    }
}
