using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Rud
{
    internal class Õpetaja2cs
    {

        public string Nimi { get; set; }
        public double Palk { get; set; }

        public Õpetaja2cs(string nimi, double palk)
        {
            Nimi = nimi;
            Palk = palk;
        }

        public virtual double CalculatorPalk()
        {
            return Palk;
        }
    }
}


