using System.ComponentModel.DataAnnotations;

namespace ZeniStudioWebBlazor.Data
{
    public class Categoria
    {
        [Key]
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
