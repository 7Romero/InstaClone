using AutoMapper;
using InstaClone.GeneralDto.User;
using InstaClone.OpenIddict.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstaClone.OpenIddict.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IMapper _mapper;

    public UserController(UserManager<ApplicationUser> userManager, IMapper mapper)
    { 
        _userManager = userManager;
        _mapper = mapper;
    } 

    [HttpGet("{id}")]
    public async Task<UserDto> FindUserById(Guid id)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());

        var userDto =  _mapper.Map<UserDto>(user);

        return userDto;
    }

    [HttpGet]
    public async Task<IEnumerable<UserDto>> GetUsers()
    { 
        var users = _userManager.Users;

        var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);

        return usersDto;
    }
}
