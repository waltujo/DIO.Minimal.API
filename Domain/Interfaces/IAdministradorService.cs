using Domain.DTOs;
using Domain.Entidades;

namespace Domain.Interfaces
{
    public interface IAdministradorService
    {
        Administrador? Login(LoginDTO loginDTO);
    }
}
