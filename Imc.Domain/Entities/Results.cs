using Imc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Domain.Entities;
public class Results
{
    public Results(decimal limit, ImcResult situation, string message)
    {
        Limit = limit;
        Situation = situation;
        Message = message;
    }

    public decimal Limit { get; private set; }

    public ImcResult Situation { get; private set; }

    public string Message { get; private set; }
}
