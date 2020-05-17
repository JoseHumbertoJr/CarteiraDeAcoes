using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarteiraDeAcoes.Model
{
    public class Acao
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set;}
        public string Data { get; set; }

    }
}
