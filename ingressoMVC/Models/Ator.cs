using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ingressoMVC.Models
{
    public class Ator : Artista
    {
        public Ator(string nome, string fotoPerfilURL, string bio) : base(nome, fotoPerfilURL, bio)
        {
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Bio { get; set; }
        public string FotoPerfilURL { get; set; }
       
    }
}
