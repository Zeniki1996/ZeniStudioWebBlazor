using System.ComponentModel.DataAnnotations;

namespace ZeniStudioWebBlazor.Data
{
    public class Categoriafiltrada
    {
        [Key]
        public int? IdCategoria { get; set; }
        public string nombre { get; set; }
        public List<Proyect> Proyectos { get; set; }
     }
}
