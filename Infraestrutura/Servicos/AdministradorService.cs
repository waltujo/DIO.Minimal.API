using Domain.DTOs;
using Domain.Entidades;
using Domain.Interfaces;
using Infraestrutura.DB;

namespace Domain.Servicos
{
    public class AdministradorService : IAdministradorService
    {
        private readonly DbContexto _contexto;
        public AdministradorService(DbContexto contexto)
        {
            _contexto = contexto;
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Password == loginDTO.Password).FirstOrDefault();
            return adm;
        }
    }
}
