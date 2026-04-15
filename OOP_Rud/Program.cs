namespace OOP_Rud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Isik inimene1 = new Isik();
            inimene1.Nimi = "Mati";
            inimene1.Sünniaasta = 2009;

            inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...


            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Nimi = "Eve";
            õpetaja1.Sünniaasta = 1980;
            õpetaja1.Aine = "Matemaatika";



            õpetaja1.Õpeta();


            Console.WriteLine("---Õpilase andmed---");
            // 2. loome Õpilase objekti
            Õpilane õpilane1 = new Õpilane();
            //päritud Isik klassist
            õpilane1.Nimi = "Markus";
            õpilane1.Sünniaasta = 2008;
            //spetrsiifilised õpilane klassile
            õpilane1.Kool = "Kutseharridus";



            Console.WriteLine("=====DIREKTOR=====");
            Õpetaja2cs opetaja = new Õpetaja2cs("Jaan Tamm", 1200.0);
            Direktor.Director direktor = new Direktor.Director("Mari Maasikas", 2000.0, 500.0);

            Console.WriteLine($"Õpetaja: {opetaja.Nimi} - Palk: {opetaja.CalculatorPalk()}");
            Console.WriteLine($"Direktor: {direktor.Nimi} - Palk: {direktor.CalculatorPalk()}");

            Console.ReadKey();





            Console.WriteLine("=====ÕPELASED======");
            Õpilane heaOpilane = new Õpilane();
            heaOpilane.Nimi = "Daniil";
            heaOpilane.KeskmineHinne = 4.0;
            heaOpilane.puudumised = 10;
            heaOpilane.KasOnsotsTõend = true;


            Õpilane pahaOpilane = new Õpilane();
            pahaOpilane.Nimi = "Artjom";
            pahaOpilane.KeskmineHinne = 3.8;
            pahaOpilane.puudumised = 35;
            pahaOpilane.KasOnsotsTõend = true;

            Console.WriteLine($"{heaOpilane.Nimi}  toetus: {heaOpilane.ArvutaPalk()} EUR");
            Console.WriteLine($"{pahaOpilane.Nimi} toetus: {pahaOpilane.ArvutaPalk()} EUR");

            Console.ReadKey();


            List<ITööline> palgasaajad = new List<ITööline>();


            Õpilane mati = new Õpilane();
            mati.Nimi = "Mati";
            mati.KeskmineHinne = 4.0;



            Õpilane kadi = new Õpilane { Nimi = "Kadi", Klass = 11, Kool = "Kutsehariduskeskus", KeskmineHinne = 4.0 };
            Õpilane jüri = new Õpilane { Nimi = "jüri", Klass = 12, Kool = "Kutsehariduskeskus", KeskmineHinne = 4.4 };

            Õpetaja peeter = new Õpetaja { Nimi = "Peeter", Aine = "C#", Tunnitasu = 25, Tunnidkuus = 60 };
            Õpetaja Anna = new Õpetaja { Nimi = "Anna", Aine = "Python", Tunnitasu = 25, Tunnidkuus = 60 };


            palgasaajad.AddRange(new ITööline[] { mati, kadi, jüri, Anna, peeter });

            //2.variant täitmine tsükli abil
            Random rnd = new Random();
            string[] nimed = { "Maria", "Kati", "Juhan", "Anna", "Siim" };
            for (int i = 0; i < nimed.Length; i++)
            {
                Õpilane õpilane = new Õpilane
                {
                    Nimi = nimed[rnd.Next(nimed.Length)],
                    Klass = rnd.Next(1, 13),
                    Kool = "THK",
                    KeskmineHinne = rnd.NextDouble() * 5,
                    puudumised = rnd.Next(0, 350), 
                    KasOnsotsTõend = rnd.Next(0, 2) == 1 
                };
                palgasaajad.Add(õpilane);
            }

            Console.WriteLine("--- Väljamaksed ---");
            
            foreach (ITööline tooline in palgasaajad)
            {
               
                Isik isik = tooline as Isik;
                Console.WriteLine($"{tooline.ArvutaPalk()} eurot. {isik?.Nimi}le");
            }

            Console.ReadLine();
        }
    }
}
