using BlazorCrud.Model;
using BlazorCrud.Data.Repositorio;
using ZeniStudioWebBlazor.Interfaz;
using ZeniStudioWebBlazor.Data;

namespace ZeniStudioWebBlazor.Servicios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly SqlCpnfiguration _configuration;
        private IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioService(SqlCpnfiguration configuration)
        {
            _configuration = configuration;
            _usuarioRepositorio = new UsuarioRepositorio(configuration.ConnectionString);
        }
        public Task<bool> DeleteUsuarios(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuarios>> GetAllUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> GetUsuarios(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveUsuarios(Usuarios usuarios)
        {
            if (usuarios.Id == "null")
                return _usuarioRepositorio.InsertUsuarios(usuarios);
            else
                return null;//ffff 
        }
    }
}