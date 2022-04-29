
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valecnici
{
    public class Hra
    {

        Banker bankerB = new Banker("Banker", 0);
        Hrac hracH = new Hrac("Hrac", 0);


        public void Hrej()
        {
            /*

            do

            {
                Console.WriteLine(" Hra Black Jack zacina, prohrava ten kdo se jako prvni dostane pres cislo 21");

                bankerB.Hra ();
                hracH.Hra();      

            } while (bankerB.PocetBodu < 22 && hracH.PocetBodu < 22);

            Console.WriteLine(bankerB.Jmeno + " ma Bodu: " + bankerB.PocetBodu);
            Console.WriteLine(hracH.Jmeno + " ma Bodu: " + hracH.PocetBodu);

            if (bankerB.PocetBodu > 21)
                                Console.WriteLine("Vyhral: " + bankerB.Jmeno);

            else Console.WriteLine("Vyhral: " + hracH.Jmeno);
            */


            Console.WriteLine(" Hra Black Jack zacina, prohrava ten kdo se jako prvni dostane pres cislo 21");

            Balicek balicek = new Balicek();
            balicek.naplnBalicek();
            balicek.vypisBalicku();


            Console.WriteLine(" Nejdrive hraje Hrac, pro další kartu zmačkněte D, pokud se dostanete přes 21 bodů prohráváte");

            string klavesa;

            while (true)

            {

                if (balicek.zbyvajiciPocetKaret() == 0)
                {
                    Console.WriteLine("dosli karty, micham");
                    balicek.naplnBalicek();
                }

                Karta karta = balicek.vytahniKaru();


                hracH.PocetBodu = hracH.PocetBodu + karta.hodnota;
                if (hracH.PocetBodu > 21)
                {
                    Console.WriteLine("Hrac prohral");
                    Console.WriteLine(" S dosaženým počtem bodů: " + hracH.PocetBodu);
                    return;
                }

                Console.WriteLine(" Váš prozatímní počet bodů: " + hracH.PocetBodu);
                Console.WriteLine(" Chcete táhnout dále? D pro další tah, N přenechat Bankéři");

                klavesa = Console.ReadLine();

                if (klavesa == "n")
                {
                    break;
                }

            }

            /*
            if (hracH.PocetBodu > 21)
            {
                Console.WriteLine("Hrac prohral");
                Console.WriteLine(" S dosaženým počtem bodů: " + hracH.PocetBodu);
            }
            */


            do

            {

                if (balicek.zbyvajiciPocetKaret() == 0)
                {
                    Console.WriteLine("dosli karty, micham");
                    balicek.naplnBalicek();
                }

                Karta karta = balicek.vytahniKaru();

                Console.WriteLine(" Banker vytahl kartu: " + karta);
                bankerB.PocetBodu = bankerB.PocetBodu + karta.hodnota;
                Console.WriteLine(" Bankéře prozatímní počet bodů: " + bankerB.PocetBodu);


            } while (bankerB.PocetBodu <= hracH.PocetBodu);



            if (bankerB.PocetBodu > 21)
            {
                Console.WriteLine("Hrac vyhral");
                Console.WriteLine(" S dosaženým počtem bodů: " + hracH.PocetBodu);
                Console.WriteLine("Banker prohral");
                Console.WriteLine(" S dosaženým počtem bodů: " + bankerB.PocetBodu);
                return;

            }


            Console.WriteLine("Hrac prohral");
            Console.WriteLine(" S dosaženým počtem bodů: " + hracH.PocetBodu);
            Console.WriteLine("Banker vyhral");
            Console.WriteLine(" S dosaženým počtem bodů: " + bankerB.PocetBodu);


        }

    }


}
