using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Rud
{
    // Добавь здесь : ITööline, если хочешь, чтобы метод считался частью интерфейса
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public double KeskmineHinne { get; set; }
        public int puudumised { get; set; } = 0;
        public bool KasOnsotsTõend { get; set; } = false;

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpilane {Nimi} ja käin {Klass} . Klass");
        }

        public double ArvutaPalk()

        {
            double põhitoetus = 0;
            double eritoetus = 0;

            if (KeskmineHinne >= 3.8 && puudumised <= 30)
            {
                põhitoetus += 60;

            }
            if (KasOnsotsTõend)
            {
                eritoetus += 120;
            }
            return põhitoetus + eritoetus;

        }

    }
}




