using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Rud
{
    internal class Enum
    {
        public enum Õppevorm
        {
            Päevane,
            Kaugõpe,
            Ekstern,
            AkadeemilinePuhkus
        }

        public class Õpilane : Isik
        {
            public int Klass { get; set; }
            public Õppevorm Staatus { get; set; } // Kasutame enumi andmetüübina

            public override void Kirjelda()
            {
                Console.WriteLine($"{Nimi} õpib {Klass}. klassis. Vorm: {Staatus}");
            }
        }
    }
}
