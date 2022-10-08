using BlazorCrud.Model;

namespace ZeniStudioWebBlazor.Interfaz
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuarios>> GetAllUsuarios();
        Task<Usuarios> GetUsuarios(int id);
        Task<bool> DeleteUsuarios(int id);
        Task<bool> SaveUsuarios(Usuarios usuarios);

    }
}
