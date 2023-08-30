using AutoMapper;
using InstaClone.GeneralDto.User;
using InstaClone.OpenIddict.Data;

namespace InstaClone.OpenIddict.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<ApplicationUser, UserDto>().ReverseMap();
    }
}
