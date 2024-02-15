using Imc.Application.Abstractions;
using Imc.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Application.Services;
public class DataBaseService : IDataBaseService
{
    private readonly IDatabaseInitializer _databaseInitializer;

    public DataBaseService(IDatabaseInitializer databaseInitializer)
    {
        _databaseInitializer = databaseInitializer;
    }

    public async Task Initialize()
    {
        await _databaseInitializer.EnsureCreatedAsync();
    }
}
