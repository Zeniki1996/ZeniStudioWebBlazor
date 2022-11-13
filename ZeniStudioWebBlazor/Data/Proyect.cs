namespace ZeniStudioWebBlazor.Data
{
    public class Proyect
    {
        public string CodigoProyeto { get; set; }
        public string nombre { get; set; }
        public int idCliente { get; set; }
        public int idEstado { get; set; }
        public string prioridad { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime? fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }
        public string? razonCancelacion { get; set; }

    }
}
