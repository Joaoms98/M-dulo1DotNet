using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;


            Console.WriteLine("Qual seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual seu peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura: ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if(imc <18.5)
            {
                Console.Write("Olá "+nome);
                Console.Write(" você está abaixo do peso");
            }
            else if(imc<25)
            {
                Console.Write("Olá " + nome);
                Console.Write(" você está com o peso normal");
            }
            else if(imc<30)
            {
                Console.Write("Olá " + nome);
                Console.Write(" você está acima do peso");
            }
            else if(imc>=30)
            {
                Console.Write("Olá " + nome);
                Console.Write(" você está com obesidade");
            }
        }
    }
}
