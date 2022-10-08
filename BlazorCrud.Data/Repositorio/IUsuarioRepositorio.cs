using BlazorCrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Data.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<IEnumerable<Usuarios>> GetAllUsuarios();
        Task<IEnumerable<Usuarios>> GetUsuarios(int id);
        Task<bool> InsertUsuarios(Usuarios usuarios);
        Task<bool> UpdateUsuarios(Usuarios usuarios);
        Task<bool> DeleteUsuarios(Usuarios usuarios);
    }
}
