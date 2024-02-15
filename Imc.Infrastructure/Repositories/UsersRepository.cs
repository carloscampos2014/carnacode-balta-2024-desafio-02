using Imc.Domain.Abstractions;
using Imc.Domain.Entities;
using Imc.Domain.Extensions;
using Imc.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Infrastructure.Repositories;
public class UsersRepository : IUsersRepository
{
    private readonly ApplicationDbContext _context;

    public UsersRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Add(Users model)
    {
        try
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model), "O modelo não pode ser nulo.");
            }

            _context.Users.Add(model);

            return await _context.SaveChangesAsync() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao adicionar usuário: {ex.Message}");
            return false;
        }
    }

    public async Task<Users> GetUser(string email, string password)
    {
        return await _context.Users.FirstOrDefaultAsync(
            f => f.Email.Equals(email, StringComparison.InvariantCultureIgnoreCase) &&
            password.ValidatePassword(f.Password));
    }
}
