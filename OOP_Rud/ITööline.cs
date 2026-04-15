using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Rud
{
    public interface ITööline
    {
        double ArvutaPalk(); //Meetod, mis arvutab tööline palga
                             // Õpetaja pärib Isik klassist JA rakendab ITööline liidest
        public class Õpetaja : Isik, ITööline
        {
            public double Tunnitasu { get; set; }
            public int TunnidNädalas { get; set; }

            public override void Kirjelda()
            {
                Console.WriteLine($"Õpetaja {Nimi}.");
            }

            // Kohustuslik meetod liidesest
            public double ArvutaPalk()
            {
                return Tunnitasu * TunnidNädalas * 4; // Kuupalk
            }
           
        }
    }
}
    
