using System;
namespace Exemploaula3_estruturaderepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine($"Posição {i} Entre com o valor se deseja somar: ");
                valor += int.Parse(Console.ReadLine());
   //valor += i; economiza o código coloca isso na linha 14
            }
            Console.WriteLine($"Somatoria: {valor}");
   //interpolação colocando cifrão antes da string, para add var colocar entre chaves
        }
    }
}

