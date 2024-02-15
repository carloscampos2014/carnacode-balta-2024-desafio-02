using Imc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Application.Abstractions;
public interface ITableImcService
{
    IList<Results> CreateTable();
}
