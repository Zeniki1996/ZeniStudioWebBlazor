using BlazorCrud.Model;
using Microsoft.Data.SqlClient;
using ZeniStudioWebBlazor.Data;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ZeniStudioWebBlazor.Servicios
{
    public class ProyectService 
    {
    

        private ApplicationDbContext context;
        public ProyectService( ApplicationDbContext context)
        {
            this.context = context;
        }
  
      public List<Proyect>GetAllProyecto()
        {
            return context.Proyect.ToList();
        }

        Task<Proyect> GetProyecto(string codigo)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProyecto(string codigo)
        {  
            context.Remove(codigo);
            context.SaveChanges();
        }

        public async Task SaveProyecto(Proyect proyect)
        {
            context.Entry(proyect).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

       
        

    //public async Task<bool> InsertProyecto(Proyect proyecto)
    //{


    //   //var db = DbConnection();
    //   // var sql = @"
    //   //             Insert into Proyectos ([CodigoProyecto], [nombre], [idCliente], 
    //   //             @[idEstado], [prioridad], [fechaCreacion], [fechaInicio], [fechaFin], [razonCancelacion])";
    //   // var result = await db.ExecuteAsync(
    //   //     sql.ToString(), new { proyecto.CodigoProyecto, proyecto.nombre, proyecto.idCliente, proyecto.idEstado, proyecto.prioridad, proyecto.fechaCreacion, proyecto.fechaInicio, proyecto.fechaFin, proyecto.razonCancelacion });
    //    //return result > 0;
    //}
 


    }
    
}
