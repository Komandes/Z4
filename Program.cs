using System;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProduktSpożywczyPaczka chleb = new ProduktSpożywczyPaczka
                {
                    Nazwa = "Chleb",
                    CenaNetto = 2.5m,
                    KategoriaVAT = "VAT-8%",
                    Kalorie = 250,
                    Alergeny = new HashSet<string> { "gluten" },
                    KrajPochodzenia = "Polska"
                };

                ProduktSpożywczyNapój<uint> sok = new ProduktSpożywczyNapój<uint>
                {
                    Nazwa = "Sok pomarańczowy",
                    CenaNetto = 3.0m,
                    KategoriaVAT = "VAT-23%",
                    Kalorie = 50,
                    Alergeny = new HashSet<string>(),
                    Objętość = 500,
                    KrajPochodzenia = "Hiszpania"
                };

                Wielopak wielopak = new Wielopak
                {
                    Produkt = chleb,
                    Ilość = 5,
                    CenaNetto = 10.0m
                };

                Console.WriteLine("Produkt:");
                Console.WriteLine("Nazwa: " + chleb.Nazwa);
                Console.WriteLine("Cena Netto: " + chleb.CenaNetto);
                Console.WriteLine("Kategoria VAT: " + chleb.KategoriaVAT);
                Console.WriteLine("Cena Brutto: " + chleb.CenaBrutto);
                Console.WriteLine("Kraj Pochodzenia: " + chleb.KrajPochodzenia);
                Console.WriteLine("Kalorie: " + chleb.Kalorie);
                Console.WriteLine("Alergeny: " + string.Join(", ", chleb.Alergeny));

                Console.WriteLine();

                Console.WriteLine("Napój:");
                Console.WriteLine("Nazwa: " + sok.Nazwa);
                Console.WriteLine("Cena Netto: " + sok.CenaNetto);
                Console.WriteLine("Kategoria VAT: " + sok.KategoriaVAT);
                Console.WriteLine("Cena Brutto: " + sok.CenaBrutto);
                Console.WriteLine("Kraj Pochodzenia: " + sok.KrajPochodzenia);
                Console.WriteLine("Kalorie: " + sok.Kalorie);
                Console.WriteLine("Alergeny: " + string.Join(", ", sok.Alergeny));
                Console.WriteLine("Objętość: " + sok.Objętość);

                Console.WriteLine();

                Console.WriteLine("Wielopak:");
                Console.WriteLine("Nazwa: " + wielopak.Produkt.Nazwa);
                Console.WriteLine("Cena Netto: " + wielopak.CenaNetto);
                Console.WriteLine("Kategoria VAT: " + wielopak.KategoriaVAT);
                Console.WriteLine("Cena Brutto: " + wielopak.CenaBrutto);
                Console.WriteLine("Kraj Pochodzenia: " + wielopak.KrajPochodzenia);
            }
            catch (Exception ex) { }
        }
    }
}