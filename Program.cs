using System;
namespace Kantor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w kantorze.");
            Console.WriteLine("Ile PLN chcesz przewalutować?");
            double pln = Convert.ToDouble(Console.ReadLine());

            double kursPlnUsd = 0.25;

            double kwotaUsd = pln * kursPlnUsd;

            Console.WriteLine("Na jaką walutę chcesz przewalutować [EUR/CHF/GBP]?");
            string waluta = Console.ReadLine().ToUpper();

            double kursUsdEur = 0.91;
            double kursUsdChf = 0.88;
            double kursUsdGbp = 0.79;

            if (waluta == "EUR")
            {
                double przewalutowaneEur = kwotaUsd * kursUsdEur;
                Console.WriteLine($"Proszę, oto Twoje {przewalutowaneEur} euro.");
            }
            

            if (waluta == "CHF")
            {
                double przewalutowaneChf = kwotaUsd * kursUsdChf;
                Console.WriteLine($"Proszę, oto Twoje {przewalutowaneChf} franki.");
            }

            if (waluta == "GBP")
            {
                double przewalutowaneGbp = kwotaUsd * kursUsdGbp;
                Console.WriteLine($"Proszę, oto Twoje {przewalutowaneGbp} funty.");
            }

            if (waluta != "EUR" || waluta != "CHF" || waluta != "GBP")
            {
                Console.WriteLine("Niestety nie posiadamy takiej waluty w naszym kantorze.");
            }

        }
    }
}