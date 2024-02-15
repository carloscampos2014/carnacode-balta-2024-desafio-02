using Imc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Domain.Abstractions;

public interface IHistoriesRepository
{
    Task<bool> Add(Histories model);

    Task<IList<Histories>> GetAll(Guid userId);
}
