using LojaVirtual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLojaVirtual.Builders
{
    public class CarrinhoDeComprasBuilder
    {
        public CarrinhoDeCompras carrinho;

        public CarrinhoDeComprasBuilder()
        {
            this.carrinho = new CarrinhoDeCompras();
        }

        public CarrinhoDeComprasBuilder ComItens(double[] valores)
        {
            foreach(double valor in valores)
            {
                carrinho.Adiciona(new Item("item", 1, valor));
            }
            return this;
        }

        public CarrinhoDeCompras Cria()
        {
            return carrinho;
        }
    }
}
