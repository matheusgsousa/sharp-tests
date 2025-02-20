using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha
{
    public class CarrinhoDeCompras
    {
        public List<Produto> Produtos { get; set; }
        public void Adicionar(Produto produto)
        {
            Produtos.Add(produto);
        }

    }
}
