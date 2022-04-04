using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura,imc;

            Console.WriteLine("Qual seu peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura: ");
            altura = float.Parse(Console.ReadLine());

            imc = peso/(altura*altura);
            Console.WriteLine("Seu ICMC: "+imc);
        }
    }
}
