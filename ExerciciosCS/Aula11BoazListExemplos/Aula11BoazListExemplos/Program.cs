using System;
using System.Collections.Generic;

namespace Aula11BoazListExemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista");

            //construção da lista
            List<string> lista = new List<string>();

            // lista feita vai aparecer o output yasmin...
            lista.Add("Yasmin");
            lista.Add("Karol");
            lista.Add("Karol");
            lista.Add("Correia");
            lista.Add("Kaique");

            //esse for é para colocar um input para o usuário inserir os dados
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Entre com o nome: ");
                var nome = Console.ReadLine();
                lista.Add(nome);
            }
            Console.WriteLine("lista:");

            //para percorrer minha lista
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
