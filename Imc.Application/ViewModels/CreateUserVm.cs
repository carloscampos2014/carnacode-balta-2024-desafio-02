using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imc.Domain.Entities;

namespace Imc.Application.ViewModels;
public class CreateUserVm
{
    public CreateUserVm()
    {
        UserName = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
        Confirmation = string.Empty;
    }

    [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
    [StringLength(30, ErrorMessage = "O tamanho máximo é de 30 caracteres.")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "O endereço de e-mail deve valido.")]
    [StringLength(300, ErrorMessage = "O tamanho máximo é de 300 caracteres.")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "A senha é obrigatória.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*])[A-Za-z\d@#$%^&*]{6,}$",
                       ErrorMessage = "A senha deve atender aos requisitos de complexidade.")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "A senha é obrigatória.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*])[A-Za-z\d@#$%^&*]{6,}$",
                       ErrorMessage = "A senha deve atender aos requisitos de complexidade.")]
    [Compare("Password", ErrorMessage = "As senhas não coincidem.")]
    public string Confirmation { get; set; }
}
