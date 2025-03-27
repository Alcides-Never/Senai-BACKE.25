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

        // Nomenclatura
        // Todo atributo privado com _
        private string _modelo;
        public int anoFabricacao;

        // Métodos
        // Get e Set

        public string GetModelo()
        {
            return _modelo;
        }

        public void SetModelo(string mod)
        {
            if (mod == "Fiesta" || mod == "HB20")
            {
                _modelo = mod;
            } else
            {
                Console.WriteLine("Alterações Inválido");
            }
        }

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
