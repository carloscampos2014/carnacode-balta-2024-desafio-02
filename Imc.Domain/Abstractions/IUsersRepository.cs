using Imc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Domain.Abstractions;
public interface IUsersRepository
{
    Task<bool> Add(Users model);

    Task<Users> GetUser(string email, string password);
}
