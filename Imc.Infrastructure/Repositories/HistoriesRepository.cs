using Imc.Domain.Abstractions;
using Imc.Domain.Entities;
using Imc.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Infrastructure.Repositories;
public class HistoriesRepository : IHistoriesRepository
{
    private readonly ApplicationDbContext _context;

    public HistoriesRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Add(Histories model)
    {
        try
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model), "O modelo não pode ser nulo.");
            }

            _context.Histories.Add(model);

            return await _context.SaveChangesAsync() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao adicionar usuário: {ex.Message}");
            return false;
        }
    }

    public async Task<IList<Histories>> GetAll(Guid userId)
    {
        return await _context.Histories
            .Where(w => w.UserId.Equals(userId))
            .ToListAsync();
    }
}
