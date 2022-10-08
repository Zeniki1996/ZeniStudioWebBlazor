﻿using BlazorCrud.Model;
using BlazorCrud.Data.Repositorio;
using ZeniStudioWebBlazor.Interfaz;
using ZeniStudioWebBlazor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ZeniStudioWebBlazor.Servicios
{
    public class UsuarioService 
    {
         private UserManager<IdentityUser> manager;
        private ApplicationDbContext context;


        public UsuarioService(UserManager<IdentityUser> manager, ApplicationDbContext context)
        {
            this.manager = manager;
            this.context = context;
        }


        public async Task DeleteUsuarios(string id)
        {
            var borrar = await GetUsuarioPorId(id);
            context.Remove(borrar);
            context.SaveChanges();
        }

        public IEnumerable<IdentityUser> GetAllUsuarios()
        {
            return manager.Users;
        }


        public async Task <IdentityUser> GetUsuarioPorId(string id)
        {
            return await manager.FindByIdAsync(id);
        }

        //public async Task CrearUsuario(IdentityUser usuario)
        //{
        //    usuario.PhoneNumber = "0000000000";
        //    usuario.TwoFactorEnabled = false;
        //    usuario.EmailConfirmed = true;
        //    usuario.PhoneNumberConfirmed = true;   

        //    await manager.CreateAsync(usuario, usuario.PasswordHash);
        //}
    }
}