using ingressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingressoMVC.Models
{
    public class Categoria : IEntidade
    {
        public Categoria(string nome)
        {
            Nome = nome;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; private set; }

        public List<FilmeCategoria> FilmesCategoria { get; set; }


    }
}
