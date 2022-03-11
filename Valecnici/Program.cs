using System;
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

            Console.WriteLine("Vítej ve Hře, boj 1 je Bojovnik vs. Kouzelnik, boj 2 je Kouzelnik vs. Lucisnik, boj 3 je Lucisnik vs Bojovnik");

            BattleUtils.vypisZivotu(b, k, l);

            Console.WriteLine("Zadej číslo boje, kdo má s kým bojovat: ");
            int cisloBoje = int.Parse(Console.ReadLine());

            switch (cisloBoje)
            {

                case 1:

                    do
                    {
                        b.ZautocNa(k);
                        k.ZautocNa(b);
                        BattleUtils.vypisZivotu(b, k, l);
                    } while (b.PocetZivotu == 0 || b.PocetZivotu < 0 || k.PocetZivotu == 0 || k.PocetZivotu < 0);
                    break;

                case 2:

                    do
                    {
                        l.ZautocNa(k);
                        k.ZautocNa(l);
                        BattleUtils.vypisZivotu(b, k, l);
                    } while (l.PocetZivotu == 0 || l.PocetZivotu < 0 || k.PocetZivotu == 0 || k.PocetZivotu < 0);
                    break;

                case 3:

                    do
                    {
                        l.ZautocNa(b);
                        b.ZautocNa(l);
                        BattleUtils.vypisZivotu(b, k, l);
                    } while (b.PocetZivotu == 0 || b.PocetZivotu < 0 || l.PocetZivotu == 0 || l.PocetZivotu < 0);
                    break;

            }

            

            BattleUtils.vypisZivotu(b, k, l);
            Console.WriteLine("Konec Hry ");



        }


    }
}
