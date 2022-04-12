using System;
using System.Collections.Generic;

namespace Lista10Cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oberse a lista dos seguintes animais: ");
                
            List<Animal> animais = new List<Animal>(
                new Animal[]
                {
                    new Elefante("Elephas maximus", "Florestas, savanas e desertos ", "Mamíferos", 41410),
                    new Babuino("antropoides cercopitecídeos", "Florestas, savanas e desertos ", "Mamíferos", 58000),
                    new Onca("Panthera onca", "Florestas tropicais ", "Mamíferos", 30000)
                });
            foreach (Animal animal in animais)
            {
                if (animal.Quantidade < 50000)
                {
                    Console.WriteLine($"Nome científico: {animal.Name} Habitat: {animal.Habitat} Classe: {animal.Classe} Quantidade na natureza: {animal.Quantidade} ");
                    animal.Apresentar("Está em risco de extinção.Vamos preservar o nosso planeta!");
                }
                else
                {
                    Console.WriteLine($"Nome científico: {animal.Name} Habitat: {animal.Habitat} Classe: {animal.Classe} Quantidade na natureza: {animal.Quantidade} ");
                    animal.Apresentar("É abundante na natureza");
                }
            }
        }
    }
}
