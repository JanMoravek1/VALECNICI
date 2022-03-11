using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valecnici;

namespace Battle
{
    public class BattleUtils
    {

        public static void vypisZivotu(Postava b, Postava k, Postava l)

        {
            Console.WriteLine("Stav zivotu " + b.Jmeno + " je : " + b.PocetZivotu);
            Console.WriteLine("Stav zivotu " + k.Jmeno + " je : " + k.PocetZivotu);
            Console.WriteLine("Stav zivotu " + l.Jmeno + " je : " + l.PocetZivotu);

        }

    }


}
