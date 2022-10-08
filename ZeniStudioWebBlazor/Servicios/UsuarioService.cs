using BlazorCrud.Model;
using BlazorCrud.Data.Repositorio;
using ZeniStudioWebBlazor.Interfaz;
using ZeniStudioWebBlazor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ZeniStudioWebBlazor.Servicios
{
    public class UsuarioService 
    {
         private ApplicationDbContext _db;

        public UsuarioService(ApplicationDbContext context)
        {
            _db = context;
        }

        public void DeleteUsuarios(string id)
        {
            var borrar =GetUsuarios(id);
            _db.usuarioList.Remove(borrar);
        }

        public IEnumerable<IdentityUser> GetAllUsuarios()
        {
            return _db.Users.ToList();
        }

        public Usuarios GetUsuarios(string id)
        {
            
            return _db.usuarioList.FirstOrDefault(u => u.Id == id);
        }

        public void SaveUsuarios(Usuarios usuarios)
        {

            var state = usuarios.Id == "" ? EntityState.Added : EntityState.Modified;
            _db.Entry(usuarios).State = state;

        }
    }
}