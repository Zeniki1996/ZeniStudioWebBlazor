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

        public async Task<Proyect> GetProyecto(string codigo)
        {
            var proyecto = await context.Proyect.FirstOrDefaultAsync(p => p.CodigoProyecto == codigo);
            return proyecto ?? new() { CodigoProyecto = codigo};
            
        }

        public async Task DeleteProyecto(string codigo)
        {
            var proyecto = await context.Proyect.FirstOrDefaultAsync(p => p.CodigoProyecto == codigo);
            context.Proyect.Remove(proyecto);
            context.SaveChanges();
        }

     
        public async Task Crear(Proyect proyect)
        {
            var proyectoExistente = await context.Proyect.FirstOrDefaultAsync(p => p.CodigoProyecto == proyect.CodigoProyecto);
            if (proyectoExistente is not null)
            {
                return;
            }
            context.Proyect.Add(proyect);
            await context.SaveChangesAsync();
        }
        public async Task<Proyect> Recomendar(Proyect proyect)
        {
            var proyectosPosibles = new List<Proyect>();
            var proyectos = await context.Proyect.ToListAsync();
            foreach (var proyecto in proyectos)
            {
                if (proyecto.idCategoria == proyect.idCategoria && proyecto.idEstado != 8 && proyecto.idEstado != 9)
                {
                    proyectosPosibles.Add(proyecto);
                }
          
            }
            //proyectosPosibles = proyectosPosibles.OrderByDescending(p => p.fechaCreacion).ToList();
            proyectosPosibles = proyectosPosibles.OrderBy(p =>
            {
                var dias = p.fechaFin - p.fechaInicio;
                if (dias is null)
                {
                    return 99; //En caso de que un proyecto aun no ha acabado, lanza un numero muy alto para no ser tomado en cuenta
                }
                return dias?.Days;
            }).ToList();

            Proyect?  proyectoRecomendado = null;
            if (proyectosPosibles.Count > 0)
            {
                proyectoRecomendado = proyectosPosibles[0];
            }
           
            if (proyectoRecomendado is null)
            {
                return new() {
                    CodigoProyecto = proyect.CodigoProyecto,
                    idCategoria =   proyect.idCategoria,
                    idCliente = proyect.idCliente,
                    fechaCreacion = DateTime.Today,
                    fechaInicio = DateTime.Now,
                    nombre = proyect.nombre,
                    idEstado = 1,
                    prioridad = "B",
                    fechaFin = DateTime.Now.AddDays(2),
                    razonCancelacion  = proyect.razonCancelacion,

                    
                };
            }
            var dias = proyectoRecomendado.fechaFin - proyectoRecomendado.fechaInicio;
            return new()
            {
                CodigoProyecto = proyect.CodigoProyecto,
                idCategoria = proyect.idCategoria,
                idCliente = proyect.idCliente,
                fechaCreacion = DateTime.Today,
                fechaInicio = DateTime.Now,
                fechaFin = DateTime.Now.AddDays(dias.GetValueOrDefault().Days),
                nombre = proyect.nombre,
                idEstado = proyectoRecomendado.idEstado,
                prioridad = proyectoRecomendado.prioridad,
                razonCancelacion=proyectoRecomendado.razonCancelacion,
            };
        }
       

 


    }
    
}
