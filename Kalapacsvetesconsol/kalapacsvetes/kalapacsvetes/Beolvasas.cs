using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalapacsvetes
{
    internal class Beolvasas
    {
        public static List<Sportolo> SportoloBeolvasas()
        {
            List<Sportolo> sportolok = new List<Sportolo>();
            // Replace the using declaration with a traditional using statement to ensure compatibility with C# 7.3  
            using (StreamReader sr = new StreamReader("kalapacsvetes.txt", Encoding.UTF8))
            {

                string elsoSor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] adatok = sor.Split(';');
                    int helyezés = int.Parse(adatok[0]);
                    double eredmény = Double.Parse(adatok[1]);
                    string sportoló = adatok[2];
                    string országkód = adatok[3];
                    string helyszín = adatok[4];
                    DateTime dátum = DateTime.Parse(adatok[5]);
                    Sportolo sportoloObjektum = new Sportolo(helyezés, eredmény, sportoló, országkód, helyszín, dátum);
                    sportolok.Add(sportoloObjektum);
                }
                return sportolok;

            }


            
        }
    }
}
