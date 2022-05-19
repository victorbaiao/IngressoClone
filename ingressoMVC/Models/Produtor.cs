﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingressoMVC.Models
{
    public class Produtor : Artista
    {
        public Produtor(string nome, string fotoPerfilURL, string bio) : base(nome, fotoPerfilURL, bio)
        {
        }

        public List<Filme> Filmes { get; set; }
    }


}
