using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaEncapsulamento.Conta
{
    class ContaCorrente : ContaBancaria
    {
        public void CobrarTaxa()
        {
            _saldo = _saldo - 15;
        }
    }
}
