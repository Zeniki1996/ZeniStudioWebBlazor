using BlazorCrud.Model;
using ZeniStudioWebBlazor.Data;

namespace ZeniStudioWebBlazor.Interfaz
{
    public interface IProyect
    {
        Task<IEnumerable<Proyect>> GetAllProyecto();
        Task<Proyect> GetProyecto(int id);
        Task<bool> DeleteProyecto(Proyect proyecto);
        Task<bool> SaveProyecto(Proyect proyect);
    }
}
