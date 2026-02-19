using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalapacsvetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Határozza meg és írja ki, hány dobás eredménye található a forrásfájlban!
            Console.WriteLine("4. feladat: Dobások száma: " + Beolvasas.SportoloBeolvasas().Count);
            //5. Határozza meg és jelenítse meg a forrásállományban szereplő magyar (HUN) sportolók dobásainak átlageredményét! Az eredményt két tizedesre kerekítve írja ki!
            var magyarSportolok = Beolvasas.SportoloBeolvasas().Where(s => s.Országkód == "HUN");
            double atlagEredmeny = magyarSportolok.Average(s => s.Eredmény);
            Console.WriteLine("5. feladat: Magyar sportolók átlagos eredménye: " + Math.Round(atlagEredmeny, 2));
            //6. Kérjen be egy évszámot és írja ki, hogy abban az évben mennyi dobás került be alegjobbak közé, illetve írja ki, hogy mely sportolók érték el ezeket.Ellenkező esetbenírja ki, hogy az adott évben nem került be egy dobás eredménye sem a legjobbak közé.
            Console.WriteLine("6. feladat: Kérem adjon meg egy évszámot: ");
            int evszam = int.Parse(Console.ReadLine());
            var adottEvDobasok = Beolvasas.SportoloBeolvasas().Where(s => s.Dátum.Year == evszam);
            if (adottEvDobasok.Count() > 0)
            {
                Console.WriteLine("Az adott évben " + adottEvDobasok.Count() + " dobás került be a legjobbak közé.");
                Console.WriteLine("A sportolók, akik elérték ezeket a dobásokat: ");
                foreach (var sportolo in adottEvDobasok)
                {
                    Console.WriteLine(sportolo.Sportoló);
                }
            }
            else
            {
                Console.WriteLine("Az adott évben nem került be egy dobás eredménye sem a legjobbak közé.");


            }
            //7. Készítsen statisztikát, hogy melyik országból hány kalapácsvetés eredménye szerepel a legjobb dobások között. Az eredményt a mintának megfelelően írassa ki a képernyőre!
            // 7. feladat: Statisztika országok szerint
            var dobások = Beolvasas.SportoloBeolvasas();
            var statisztika = dobások
                .GroupBy(s => s.Országkód)
                .Select(g => new { Országkód = g.Key, DobásokSzáma = g.Count() });

            Console.WriteLine("7. feladat: Statisztika");
            foreach (var item in statisztika)
            {
                Console.WriteLine($"{item.Országkód} - {item.DobásokSzáma}");
            }

            //8. Hozzon létre magyarok.txt néven egy UTF-8 kódolású fájlt, amelyben csak a magyar(HUN)sportolók eredményei szerepelnek.
            var magyarSportolokEredmenyei = Beolvasas.SportoloBeolvasas().Where(s => s.Országkód == "HUN");
            Console.WriteLine(
                "8. feladat: magyarok.txt fájl létrehozása...");
            using (StreamWriter sw = new StreamWriter("magyarok.txt", false, Encoding.UTF8))
            {
                sw.WriteLine("Helyezés;Eredmény;Sportoló;Országkód;Helyszín;Dátum");
                foreach (var sportolo in magyarSportolokEredmenyei)
                {
                    sw.WriteLine($"{sportolo.Helyezés};{sportolo.Eredmény};{sportolo.Sportoló};{sportolo.Országkód};{sportolo.Helyszín};{sportolo.Dátum:yyyy-MM-dd}");
                }
                sw.Close();
                Console.WriteLine(
                    "A magyarok.txt fájl sikeresen létrehozva!");

    

            }
        }
    }
}
