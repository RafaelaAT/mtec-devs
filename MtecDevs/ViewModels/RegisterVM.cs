using System.ComponentModel.DataAnnotations;
namespace MtecDevs.ViewModels;

public class RegisterVM
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string Senha { get; set; }
    public byte TipoDevId { get; set; }
    public string Foto { get; set; }
};
