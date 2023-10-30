using InstaClone.GeneralDto.User;
using InstaClone.UserManagement.Infrastructure.HttpClients.Interfaces;
using System.Net.Http.Json;

namespace InstaClone.UserManagement.Infrastructure.HttpClients;

public class HttpUserDataClient : IUserDataClient
{
    private readonly HttpClient _httpClient;

    public HttpUserDataClient(HttpClient httpClient) 
    {
        _httpClient = httpClient;
    }

    public async Task<List<UserDto>> GetUsers()
    {
        var response = await _httpClient.GetAsync("https://localhost:44313/api/user");

        var users = await response.Content.ReadFromJsonAsync<List<UserDto>>();

        return users;
    }
}
