using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Produto(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
