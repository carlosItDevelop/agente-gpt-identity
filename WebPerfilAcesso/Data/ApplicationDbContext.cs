using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebPerfilAcesso.Models;

namespace WebPerfilAcesso.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebPerfilAcesso.Models.TipoUsuario> TipoUsuario { get; set; }
        public DbSet<WebPerfilAcesso.Models.AcessoTipoUsuario> AcessoTipoUsuario { get; set; }
        public DbSet<WebPerfilAcesso.Models.PerfilUsuario> PerfilUsuario { get; set; }

        public DbSet<IdentityUser> Usuario { get; set; }
    }
}
