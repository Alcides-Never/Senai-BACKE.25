using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaEncapsulamento
{
    class Retangulo
    {
        private int _largura;
        private int _altura;

        public void SetLargura(int valor)
        {
            _largura = valor;
            //return _largura;
        }

        public void SetAltura(int valor)
        {
            _altura = valor;
        }
        public int GetLargura()
        {
            return _largura;
        }

        public int GetAltura() 
        {
            return _altura;
        }

        public double CalcularArea()
        {
            return _altura * _largura;
        }
    }
}
