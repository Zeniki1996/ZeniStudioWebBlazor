using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZeniStudioWebBlazor.Pages;

namespace ZeniStudioWebBlazor.Data
{
    [Table ("Proyecto")]
    public class Proyect
    {

        // public int idProyect { get; set; }
        [Key]
        public string CodigoProyecto { get; set; } 
        public string nombre { get; set; }
        public Byte idCategoria { get; set; }
        public int idCliente { get; set; }
        public int idEstado { get; set; }
        public string prioridad { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime? fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }
        public string? razonCancelacion { get; set; }

    }
  
}
