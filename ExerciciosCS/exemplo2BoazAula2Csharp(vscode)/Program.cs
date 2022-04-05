using System;

namespace exemplo2BoazAula2Csharp_vscode_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com valor vendido mensal: ");
            double valorvendido = double.Parse(Console.ReadLine());
            
            if(valorvendido <=10000)
            {
                Console.WriteLine("O valor a receber: R$"+(valorvendido*0.01));
            }
            else if(valorvendido<=20000)
            {
                Console.WriteLine("O valor a receber: R$"+(valorvendido*0.02));
            }
            else if(valorvendido<=30000)
            {
                Console.WriteLine("O valor a receber: R$"+(valorvendido*0.03));    
            }
            else
            {
               Console.WriteLine("O valor a receber: R$"+(valorvendido*0.1)); 
            }
        }
    }
}
