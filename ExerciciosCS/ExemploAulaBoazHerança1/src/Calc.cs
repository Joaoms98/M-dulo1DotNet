using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAulaBoazHerança1.src
{
    internal class Calc : IOperacoes
    {
        public double Dividir(double a, double b)
        {
            return a/b;
        }
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public double Somar(double a, double b)
        {
            return a+b;
        }
        public double Subtrair(double a, double b)
        {
            return a-b;
        }
    }
}
