using System;
using System.Collections.Generic;
using Valecnici;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Bojovnik b = new Bojovnik("Hektor", 2);
            Kouzelnik k = new Kouzelnik("Merlin", 6);
            Lucisnik l = new Lucisnik("Legolas", 4);

            List<Postava> postavy = new List<Postava>();
            postavy.Add(b);
            postavy.Add(k);
            postavy.Add(l);

            //Console.WriteLine("Vítej ve Hře, boj 1 je Bojovnik vs. Kouzelnik, boj 2 je Kouzelnik vs. Lucisnik, boj 3 je Lucisnik vs Bojovnik");

            BattleUtils.vypisZivotu(b, k, l);

            Postava p1 = null;
            Postava p2 = null;

            int cislo1;

            do

            {
                Console.WriteLine("Zadej číslo druhého bojovníka bojovník(0), kouzelník(1), lučišník(2)");
                cislo1 = int.Parse(Console.ReadLine());

                if (cislo1 > postavy.Count - 1)
                    Console.WriteLine("Může zadat pouze čísla od 0 - 2, zkuste znovu");

                else Console.WriteLine("Zvolili jste " + cislo1);

            } while (cislo1 > postavy.Count - 1);

            p1 = postavy[cislo1];

            int cislo2;

            do

            {
                Console.WriteLine("Zadej číslo druhého bojovníka bojovník(0), kouzelník(1), lučišník(2)");
            cislo2 = int.Parse(Console.ReadLine());

                if (cislo2 > postavy.Count - 1)
                    Console.WriteLine("Může zadat pouze čísla od 0 - 2, zkuste znovu");

                else if (cislo2 == cislo1) 
                    Console.WriteLine("Nemůžete zvolit stejného bojovníka, zkuste znovu");

                else Console.WriteLine("Zvolili jste " + cislo2);

            } while (cislo2 > postavy.Count - 1 || cislo2 == cislo1);

   
            p2 = postavy[cislo2];

            do
            {
                p1.ZautocNa(p2);
                p2.ZautocNa(p1);
                BattleUtils.vypisZivotu(b, k, l);
            } while (p1.PocetZivotu > 0 && p2.PocetZivotu > 0);

            
            Console.WriteLine("Konec Hry ");

        }


    }
}
