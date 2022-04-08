using System;

namespace Lista8CS.src
{
    internal class violao
    {
        //atributos
        public string Name,Color;
        public double Preco;
        //construtor
        public violao(string _name,string _color,double _preco)
        {
            Name = _name;
            Color = _color;
            Preco = _preco;
        }
        //método
        public void sound (string sound)  //pode fazer assimmmmm. na hora de chamar eu chamo ele pelo nome memo Giannini.sound("Seco");
        {
            Console.WriteLine($"O {Name} tem um som {sound}");
        }
        public string acordes() // ou assimmm.Na hora de chamar eu chamo Console.WriteLine(Giannini.acordes());
        {
            return "C#,A#-";
        }
    }
}
