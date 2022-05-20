﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ingressoMVC.Models
{
    public class FilmeCategoria
    {
        public FilmeCategoria(int filmeId, int categoriaId)
        {
            FilmeId = filmeId;
            CategoriaId = categoriaId;
        }

        [Key]
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }

        [Key]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

      
    }
}
