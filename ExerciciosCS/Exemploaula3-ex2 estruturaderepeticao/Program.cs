using System;

namespace Exemploaula3_ex2_estruturade_repeticao_vscode_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");
            for(int x=0;x<=10;x++)
            {
                Console.WriteLine($"Tabuada do: {+x}");
                for(int y=1;y<=10;y++)
                {
                    Console.WriteLine($"{x}x{y}={x*y}");
                }
            }
        }
    }
}
