using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Valecnici
{
    class Balicek
    {
        private List<Karta> karty = new List<Karta>();

        public void naplnBalicek()
        {

            string[] barvy = new string[] { "Srdce", "Piky", "Kary", "Kule" };
            string[] druhy = new string[] { "sedm", "osm", "devet", "deset", "spodek", "svršek", "kral", "eso" };
            int[] hodnoty = new int[] { 7, 8, 9, 10, 1, 1, 2, 11 };

            List<Karta> pomocneKarty = new List<Karta>();

            foreach (string barva in barvy)
            {
                for (int i = 0; i < druhy.Length; i++)
                {
                    Karta karta = new Karta(druhy[i], barva, hodnoty[i]);

                    pomocneKarty.Add(karta);
                    //karty.Add(karta);
                }
            }

            Random rnd = new Random();

            karty = pomocneKarty.OrderBy(item => rnd.Next()).ToList();

        }

        public Karta vytahniKaru()
        {
            Karta karta = karty.ElementAt(0);
            karty.RemoveAt(0);
            return karta;
        }

        public int zbyvajiciPocetKaret()
        {
            return karty.Count;
        }



        public void vypisBalicku ()

        {
            for (int i = 0; i < karty.Count; i++)
            {
                
                Console.WriteLine(karty.ElementAt(i).druh + karty[i].barva + karty[i].hodnota);
            }
        }

    }
}
