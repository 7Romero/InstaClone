using HotChocolate.Authorization;
using InstaClone.GeneralDto.User;
using InstaClone.UserManagement.Infrastructure.HttpClients.Interfaces;
using System.Security.Claims;

namespace InstaClone.UserManagement.API.GraphApi.Queries;

[ExtendObjectType("Query")]
public class UserQueries
{
    [Authorize]
    public async Task<IList<UserDto>> GetUsersAsync([Service] IUserDataClient _userDataClient)
    {
        var users = await _userDataClient.GetUsers();

        return users;
    }

    public IEnumerable<string> GetMe(ClaimsPrincipal claimsPrincipal)
    {
        return claimsPrincipal.Claims.Select(c => $"{c.Type}: {c.Value}");
    }
}
