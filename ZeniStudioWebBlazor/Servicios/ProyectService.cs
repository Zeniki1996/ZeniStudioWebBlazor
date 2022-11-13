using BlazorCrud.Model;
using Microsoft.Data.SqlClient;
using ZeniStudioWebBlazor.Data;
using ZeniStudioWebBlazor.Interfaz;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeniStudioWebBlazor.Servicios
{
    public class ProyectService : IProyect
    {
        private string ConnectionString;
        public ProyectService(string connectionString)
        {
            ConnectionString = connectionString;
        }
        private SqlConnection DbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public Task<bool> DeleteProyecto(Proyect proyecto)
        {
            throw new NotImplementedException();
        }
      

        Task<IEnumerable<Proyect>> IProyect.GetAllProyecto()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Proyect>> GetProyecto(int id)
        {
            throw new NotImplementedException();
        }
        Task<Proyect> IProyect.GetProyecto(int id)
        {
            throw new NotImplementedException();
        }

        //public async Task<bool> InsertProyecto(Proyect proyecto)
        //{
          

        //   //var db = DbConnection();
        //   // var sql = @"
        //   //             Insert into Proyectos ([CodigoProyecto], [nombre], [idCliente], 
        //   //             @[idEstado], [prioridad], [fechaCreacion], [fechaInicio], [fechaFin], [razonCancelacion])";
        //   // var result = await db.ExecuteAsync(
        //   //     sql.ToString(), new { proyecto.CodigoProyeto, proyecto.nombre, proyecto.idCliente, proyecto.idEstado, proyecto.prioridad, proyecto.fechaCreacion, proyecto.fechaInicio, proyecto.fechaFin, proyecto.razonCancelacion });
        //    //return result > 0;
        //}


        public Task<bool> SaveProyecto(Proyect proyect)
        {
            throw new NotImplementedException();
        }
    }
    
}
