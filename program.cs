namespace OOP_Rud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Isik inimene1 = new Isik();
            inimene1.Nimi = "Mati";
            inimene1.Sünniaasta =2009;

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
            õpilane1.Sünniaasta =2008;
            //spetrsiifilised õpilane klassile
            õpilane1.Kool = "Kutseharridus";




        }
    }
    
}
