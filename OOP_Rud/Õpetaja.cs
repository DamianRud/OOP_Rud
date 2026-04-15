using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Rud
{
    public class Õpetaja : Isik, ITööline
    {

        public string Aine { get; set; }

        public int Tunnitasu { get; set; }
        public int Tunnidkuus { get; set; }

        public TööTüüp VäljamakseTüüp { get; set; }

        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        public double ArvutaPalk()
        {
            return Tunnitasu * Tunnidkuus;
        }
    }
}



