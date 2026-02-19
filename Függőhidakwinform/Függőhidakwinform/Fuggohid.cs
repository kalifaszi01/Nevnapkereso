using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Függőhidakwinform
{
    internal class Fuggohid
    {
        //1. Hozzon létre saját osztályt Fuggohid azonosítóval, melynek adattagjait felhasználva egy-egy híd adatait tudja majd tárolni és készítse el a Fuggohid osztály konstruktorát, mely hívásával az osztály adattagjait tudja inicializálni! A projektet Fuggohidak néven mentse el!
        public int Helyezés { get; set; }
        public string Híd { get; set; }
        public string Hely { get; set; }
        public string Ország { get; set; }
        public int Hossz { get; set; }
        public int Év { get; set; }

        public Fuggohid(int helyezés, string híd,string helye, string ország, int hossz, int év)
        {
            Helyezés = helyezés;
            Híd = híd;
            Hely = helye;
            Ország = ország;
            Hossz = hossz;
            Év = év;
        }

        internal static object Select(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
