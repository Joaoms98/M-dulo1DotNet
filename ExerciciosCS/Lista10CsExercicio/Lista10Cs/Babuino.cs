using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10Cs
{
    public class Babuino : Animal
    {
        public Babuino(string name, string habitat, string classe, int quantidade) : base(name, habitat, classe, quantidade) { }

        public override void Apresentar(string apresentar)
        {
            Console.WriteLine($"{apresentar}");
        }
    }
}
