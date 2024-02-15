using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Domain.Entities;

public class Users
{
    public Users()
    {
        Id = Guid.NewGuid();
        UserName = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
        Histories = new List<Histories>();
    }

    public Guid Id { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public List<Histories> Histories { get; set; }
}
