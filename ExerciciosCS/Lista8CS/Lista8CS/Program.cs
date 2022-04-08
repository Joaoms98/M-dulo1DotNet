using System;
using Lista8CS.src;


namespace Lista8CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            violao Giannini = new violao("Giannini", "castanho claro", 1200);   // informar os valores dos atributos
            violao Tagima = new violao("Tagima", "preto", 800);
            violao Digiorgi = new violao("Digiorgi", "castanho escuro", 1800);

            Console.WriteLine($"violao {Giannini.Name} é {Giannini.Color} e custa {Giannini.Preco}");
            Giannini.sound("Seco");
            Console.WriteLine($"nos acordes: {Giannini.acordes()}");
        }
    }
}
