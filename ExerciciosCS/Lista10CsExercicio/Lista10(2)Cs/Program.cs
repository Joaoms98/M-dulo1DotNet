using System;

namespace Lista10_2_Cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular a área de uma figura geométrica inserindo os dados 1,70 para altura e 1,10 para a base");
            
            Area area = new Area();

            Console.WriteLine($"A área  é: {area.AlturaBase(1.70,1.10)}");
        }
    }
}
