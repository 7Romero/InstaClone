using InstaClone.GeneralDto.User;

namespace InstaClone.UserManagement.Infrastructure.HttpClients.Interfaces;

public interface IUserDataClient
{
    public Task<List<UserDto>> GetUsers();
}
