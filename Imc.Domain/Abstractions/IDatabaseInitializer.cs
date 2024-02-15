using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Domain.Abstractions;
public interface IDatabaseInitializer
{
    Task EnsureCreatedAsync();
}
