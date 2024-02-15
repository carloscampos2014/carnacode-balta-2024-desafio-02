using Imc.Application.Abstractions;
using Imc.Application.Resourses;
using Imc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Application.Services;
public class TableImcService : ITableImcService
{
    public IList<Results> CreateTable()
    {
        return new List<Results>()
        {
            new Results(40, Domain.Enums.ImcResult.ObsesidadeGrave, Messages.ObesidadeGrave),
            new Results(35, Domain.Enums.ImcResult.Obesidade,Messages.Obesidade),
            new Results(30, Domain.Enums.ImcResult.Sobrepeso,Messages.Sobrepeso),
            new Results(18.5m, Domain.Enums.ImcResult.Normal,Messages.Normal),
            new Results(0, Domain.Enums.ImcResult.Magreza,Messages.Magreza),
        };
    }
}
