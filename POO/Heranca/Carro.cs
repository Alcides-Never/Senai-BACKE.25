using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro
    {
        public string modelo;
        public string marca;
        public int quilometragem;

        // Virtual - Esse método pode ser sobrescrito
        public virtual void MostrarInformacoes()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Quilometragem: " + quilometragem);
        }

        // Um método com o mesmo nome pode receber coisas diferentes
        public void MostrarInformacoes(string nome)
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Quilometragem: " + quilometragem);
            Console.WriteLine("Nome: " + nome);
        }
    }
}
