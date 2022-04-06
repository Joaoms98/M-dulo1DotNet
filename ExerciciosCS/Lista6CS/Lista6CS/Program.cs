using System;

namespace Lista6CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe qual tabuada gostaria de saber:  ");
            int x=int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do: {+x}");
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine(x + "x" + y + "=" + x * y);
                }
        }
    }
}
