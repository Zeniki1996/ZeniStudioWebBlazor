using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using ZeniStudioWebBlazor.Data;

namespace ZeniStudioWebBlazor.Servicios
{
    public class CategoriaService
    {

        private ApplicationDbContext context;
        public CategoriaService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task <bool> existe (int idCategoria)
        {
            return await context.Categoria.AnyAsync(c => c.idCategoria == idCategoria);
        }
        public async Task<List<Categoriafiltrada>> RetornarLista(DateTime fechainicio, DateTime fechafin)
        {
            
            var proyecto = await context.Proyect.Where(p => p.fechaCreacion >= fechainicio && p.fechaCreacion <= fechafin && p.idEstado == 5)
            .GroupBy(p => p.idCategoria).Select(g => new Categoriafiltrada
            {
                IdCategoria = g.Key,
                nombre = context.Categoria.FirstOrDefault(c => c.idCategoria == g.Key).nombre,
                Proyectos = g.ToList()
            }).ToListAsync();

            return proyecto;
        }
    }
}
