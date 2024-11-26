using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6___Animal
{
    public abstract class Animal
    {
        public string Especie { get; set; }
        public abstract void EmitirSom();
    }

    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O GATO FAZ miau, miau");
        }
    }

    public class Porco : Animal
    {
       
        public override void EmitirSom()
        {
            Console.WriteLine("O PORCO FAZ oinc, oinc");
        }
    }


    public class Capivara : Animal
    {
    
        public override void EmitirSom()
        {
            Console.WriteLine("A CAPIVARA FAZ ahn, ahn");
        }
    }
}
