using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingressoMVC.Models
{
    public class AtorFilme
    {
        public int AtorId { get; set; }
        public Ator Ator { get; set; }
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }
    }
}
