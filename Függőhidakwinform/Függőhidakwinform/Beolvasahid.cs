using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Függőhidakwinform
{
    internal class Beolvasahid
    {
        public static List<Fuggohid> FuggohidBeolvasas()
        {
            List<Fuggohid> fuggohidak = new List<Fuggohid>();
            using (StreamReader sr = new StreamReader("fuggohidak.csv", Encoding.UTF8))
            {
                string elsoSor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] adatok = sor.Split('\t');
                    int helyezés = int.Parse(adatok[0]);
                    string híd = adatok[1];
                    string helye = adatok[2];
                    string ország = adatok[3];
                    int hossz = int.Parse(adatok[4]);
                    int év =int.Parse(adatok[5]);
                    Fuggohid fuggohid = new Fuggohid(helyezés, híd,helye, ország, hossz, év);
                    fuggohidak.Add(fuggohid);
                }
                return fuggohidak;

            }
        }
    }
}
