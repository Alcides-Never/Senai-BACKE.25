using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

       public double CalcularTotal()
        {
            double calcularTotal = preco * quantidadeEmEstoque;
            return calcularTotal;

        }
    }
}
