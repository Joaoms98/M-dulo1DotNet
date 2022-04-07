using System;

namespace Lista7CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Pressione I para iniciar");
            string inicializador = Console.ReadLine();

            while(inicializador=="I")
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o operador: ");
                string operador = Console.ReadLine();

                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                switch (operador)
                {
                    case "+":
                        Console.WriteLine($"Resultado:{num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Resultado:{num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Resutado:{num1 * num2}");
                        break;
                    case "/":
                        Console.WriteLine($"Resultado:{num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("operador invalido");
                        break;
                }
                Console.WriteLine("Pressione E para sair ou qualquer letra para continuar");
                string finalizador = Console.ReadLine();

                if(finalizador=="E")
                {
                    break;
                }
            } 
        }
    }
}
