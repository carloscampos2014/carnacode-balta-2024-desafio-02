using Imc.Application.Abstractions;
using Imc.Application.ViewModels;
using Imc.Domain.Abstractions;
using Imc.Domain.Entities;
using Imc.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Application.Services;
public class UsersService : IUsersService
{
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<bool> AddUser(CreateUserVm model)
    {
        var User = new Users
        {
            UserName = model.UserName,
            Email = model.Email,
            Password = model.Password.GeneratePasswordHash(),
        };

        return await _usersRepository.Add(User);
    }
}
