using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioHerancaEncapsulamento.Conta;

namespace ExercicioHerancaEncapsulamento
{
    class ContaPoupanca : ContaBancaria
    {
        public void RenderJuros()
        {
            _saldo = _saldo * 1.05;
        }
    }
}
