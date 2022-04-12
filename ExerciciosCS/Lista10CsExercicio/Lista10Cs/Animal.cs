using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10Cs
{
    public class Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string Classe { get; set; }
        public int Quantidade { get; set; }

        public Animal(string name,string habitat, string classe, int quantidade)
        {
            Name = name;
            Habitat = habitat;
            Classe = classe;
            Quantidade = quantidade;
        }
        public virtual void Apresentar(string apresentar)
        {
            Console.WriteLine($"{Name} está em extinção.{apresentar}");
        }
    }
}
