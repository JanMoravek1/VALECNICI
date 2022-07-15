using System;
using System.Collections.Generic;
using Valecnici;
namespace Valecnici

{
    public class Objednavka
    {

        public string Jmeno { get; set; }
        public int pozadovanaKapacita { get; set; }
        public List<string> pozadovaneVybaveni = new List<string>();
        public int Zacatek { get; set; }
        public int Konec { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }


        public Objednavka()
        {
            Console.WriteLine("Vytvorte svoji objednavku ");
            Console.WriteLine("Zadejte svoje jmeno ");
            string Jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte pocet osob ");
            pozadovanaKapacita = int.Parse(Console.ReadLine());

            while (true)

            {
                Console.WriteLine("Zadejte svoje pozadovane vybaveni ");
                string nabytek = Console.ReadLine();
                pozadovaneVybaveni.Add(nabytek);

                Console.WriteLine(" Chcete zadat dalsi vybaveni? D pro další, N konec zadání vybavení");

                string klavesa = Console.ReadLine();

                if (klavesa == "n")
                {
                    break;
                }

            }

            Console.WriteLine("Zadejte zacatek pobytu ");
            Zacatek = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte konec pobytu ");
            Konec = int.Parse(Console.ReadLine());

        }

    }
}