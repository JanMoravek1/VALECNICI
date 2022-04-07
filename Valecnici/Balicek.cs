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
            //string[] barvy = new string[] { "Srdce", "Piky", "Kary", "Kule" };
            //string[] druhy = new string[] { "desidka", "kluk", "dama", "kral", "eso" };
            //int[] hodnoty = new int[] { 10, 2, 2, 2, 11 };

            string[] barvy = new string[] { "Srdce" };
            string[] druhy = new string[] { "desidka", "kluk" };
            int[] hodnoty = new int[] { 10, 2, };


            //List<Karta> pomocneKarty = new List<Karta>();

            foreach (string barva in barvy)
            {
                for (int i = 0; i < druhy.Length; i++)
                {
                    Karta karta = new Karta(druhy[i], barva, hodnoty[i]);
                    //pomocneKarty.Add(karta);
                    karty.Add(karta);
                }
            }

            //Random rnd = new Random();

            //karty = pomocneKarty.OrderBy(item => rnd.Next());
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

    }
}
