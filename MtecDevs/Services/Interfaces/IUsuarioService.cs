namespace MtecDevs.Services.Interfaces;
using MtecDevs.ViewModels;

public interface UsuarioService
{
     Task<UsuarioVM> GetUsuarioLogado();
}
