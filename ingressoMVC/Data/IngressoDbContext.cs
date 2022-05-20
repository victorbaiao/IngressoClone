using ingressoMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingressoMVC.Data
{
    public class IngressoDbContext : DbContext
    {
        public IngressoDbContext(DbContextOptions<IngressoDbContext>options)
            : base (options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AtorFilme>().HasKey(af => new 
            { 
            af.AtorId,
            af.FilmeId

            });

            modelBuilder.Entity<FilmeCategoria>().HasKey(fc => new
            {
                fc.CategoriaId,
                fc.FilmeId
                

            }); 

        }


        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Ator> Atores { get; set; }

        public DbSet<Artista> Artista { get; set; }

        public DbSet<Produtor> Produtor { get; set; }
        public DbSet<AtorFilme> AtorFilme { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<FilmeCategoria> FilmeCategoria { get; set; }


    }
}
