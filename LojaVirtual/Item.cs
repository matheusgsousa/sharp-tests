using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual
{
    public class Item
    {
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public double ValorUnitario { get; private set; }
        public Item(String descricao,
        int quantidade,
        double valorUnitario)
        {
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.ValorUnitario = valorUnitario;
        }
        public double ValorTotal
        {
            get
            {
                return this.ValorUnitario * this.Quantidade;
            }
        }
    }
}
