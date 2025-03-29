using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class CarroEletrico : Carro
    {
        public int bateria;
        public int tempoDeCarga;

        public override void MostrarInformacoes()
        {
            //Console.WriteLine("Modelo: " + modelo);
            //Console.WriteLine("Marca: " + marca);
            //Console.WriteLine("Quilometragem: " + quilometragem);
            base.MostrarInformacoes();  
            Console.WriteLine("Bateria: " + bateria);
            Console.WriteLine("Tempo de Carga" + tempoDeCarga);
        }
    }
}
