using Imc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Domain.Entities;

public class Histories
{
    public Histories()
    {
        Id = Guid.NewGuid();
        UserId = Guid.NewGuid();
        User = new Users();
    }

    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public decimal Height { get; set; }

    public decimal Weight { get; set; }

    public decimal Imc { get; set; }

    public ImcResult Result { get; set; }

    public Users User { get; set; }
}
