﻿

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZeniStudioWebBlazor.Data;

namespace ZeniStudioWebBlazor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ZeniStudioWebBlazor.Data.Proyect> Proyect { get; set; }
        public DbSet<ZeniStudioWebBlazor.Data.Categoria> Categoria { get; set; }
       

    }
}