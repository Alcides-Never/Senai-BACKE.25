using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Carro
    {
        // Atributos
        public string marca;
        public string modelo;
        public int anoFabricacao;

        // Métodos
        public void Andar()
        {
            Console.WriteLine("Carro está andando!");
        }
        public void Parar()
        {
            Console.WriteLine("Carro está parando");
        }
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano de Fabricação: {anoFabricacao}");
        }
    }
}
