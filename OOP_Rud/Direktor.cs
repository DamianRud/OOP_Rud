using System;
using System.Collections.Generic;
using System.Text;


namespace OOP_Rud
{
    internal class Direktor
    {
        public class Director : Õpetaja2cs
        {
            public double Bonus { get; set; }

            public Director(string nimi, double palk, double bonus)
                : base(nimi, palk)
            {
                Bonus = bonus;
            }


            public override double CalculatorPalk()
            {
                return base.CalculatorPalk() + Bonus;
            }
        }
    }
}


