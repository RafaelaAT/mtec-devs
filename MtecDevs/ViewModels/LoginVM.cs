using System.ComponentModel.DataAnnotations;
namespace MtecDevs.ViewModels;

public class LoginVM
{
    [Display(Name = "Email Ou Nome de Usuário", Prompt = "Informe Seu Email Ou Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, Informe Seu Email Ou Nome de Usuário")]
    public string Email { get; set; }

    [Display(Name = "Senha de acesso", Prompt = "Informe sua senha de Acesso")]
    [Required(ErrorMessage = "Por favor, Informe sua senha de Acesso")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; }

    public string UrlRetorno { get; set; }
}