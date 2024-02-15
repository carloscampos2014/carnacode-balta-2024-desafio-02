using Imc.Application.Abstractions;
using Imc.Application.Services;
using Imc.Domain.Abstractions;
using Imc.Infrastructure.Context;
using Imc.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Imc.CrossCutting;

public static class DenpendecyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<IUsersService, UsersService>();
        services.AddScoped<ITableImcService, TableImcService>();
        services.AddScoped<IDataBaseService, DataBaseService>();
        return services;
    }

    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration
            .GetConnectionString("Sqlite");
        services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite(connectionString));
        services.AddScoped<IUsersRepository, UsersRepository>();
        services.AddScoped<IHistoriesRepository, HistoriesRepository>();
        services.AddScoped<IDatabaseInitializer, DatabaseInitializer>();
        return services;
    }
}
