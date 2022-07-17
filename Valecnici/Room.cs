using System;
using System.Collections.Generic;
using Valecnici;

namespace Valecnici
{
    public class Room
    {
        public int cislo { get; set; }
        public int kapacita { get; set; }
        public List<string> vybaveni;
        public List<Rezervace> rezervace = new List<Rezervace>();

        public void vypisPokoje()
        {
            Console.WriteLine("Cislo pokoje =" + cislo);
            Console.WriteLine("Kapacita pokoje =" + kapacita);

            for (int i = 0; i < vybaveni.Count; i++)
            {

                Console.WriteLine(vybaveni[i]); //nejde element at? Console.WriteLine(karty.ElementAt(i).druh + karty[i].barva + karty[i].hodnota);
            }

        }

        public static Room vytvorPokoj()
        {
            Console.WriteLine("Zadejte cislo pokoje ");
            int cislo = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte kapacitu pokoje ");
            int kapacita = int.Parse(Console.ReadLine());

            List<string> vybaveni = new List<string>();
            while (true)

            {
                Console.WriteLine("Zadejte vybaveni pokoje ");
                string nabytek = Console.ReadLine();
                vybaveni.Add(nabytek);

                Console.WriteLine(" Chcete zadat dalsi vybaveni? D pro další, N konec zadání vybavení");

                string klavesa = Console.ReadLine();

                if (klavesa == "n")
                {
                    break;
                }

            }

            return new Room(cislo, kapacita, vybaveni);

        }

        public Room(int cislo, int kapacita, List<string> vybaveni)
        {
            this.cislo = cislo;
            this.kapacita = kapacita;
            this.vybaveni = vybaveni;
        }
    }
}

