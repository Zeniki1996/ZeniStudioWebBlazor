using Microsoft.EntityFrameworkCore;
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
    }
}
