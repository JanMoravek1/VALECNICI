using System;
using System.Collections.Generic;
using Valecnici;

namespace Valecnici
{
    public class Hotel
    {

        public List<Room> hotel = new List<Room>();

        public void naplnHotel()
        {
            Console.WriteLine("Kolik pokojů bude mít hotel ");
            int pocet = int.Parse(Console.ReadLine());

            for (int i = 0; i < pocet; i++)
            {
                Room pokoj = Room.vytvorPokoj();
                hotel.Add(pokoj);

            }

        }


        public void vypisHotelu()
        {
            for (int i = 0; i < hotel.Count; i++)
            {
                Console.WriteLine("Cislo pokoje =" + hotel[i].cislo);
                Console.WriteLine("Kapacita pokoje =" + hotel[i].kapacita);
                Console.WriteLine("Vybaveni pokoje =" + hotel[i].kapacita);
                for (int y = 0; y < hotel[i].vybaveni.Count; y++)
                {
                    Console.WriteLine(hotel[i].vybaveni[y]);

                }


            }

        }


        public void vytvorRezervaci(Objednavka o)
        {
            for (int i = 0; i < hotel.Count; i++)
            {
                if (hotel[i].kapacita == o.pozadovanaKapacita)
                {
                    if (hotel[i].rezervace.Count < 1)
                    {
                        Rezervace r = new Rezervace(o.Jmeno, o.Zacatek, o.Konec);
                        hotel[i].rezervace.Add(r);
                        Console.WriteLine("Rezervace vytvořena, Cislo pokoje =" + hotel[i].cislo);
                        break;
                    }

                    else if (hotel[i].rezervace.Count >= 1)
                    {
                        for (int y = 0; y < hotel[i].rezervace.Count; y++)
                        {
                            // já myslím, že toto je predasné vytvoření rezervace, teprve až projdeme všechny rezervace a ani jendna nekoliduje, tak můžeme novou rezervaci vytvořit
                            if (o.Zacatek < hotel[i].rezervace[y].Zacatek && o.Konec < hotel[i].rezervace[y].Konec)
                            {
                                Rezervace r = new Rezervace(o.Jmeno, o.Zacatek, o.Konec);
                                hotel[i].rezervace.Add(r);
                                Console.WriteLine("Rezervace vytvořena, Cislo pokoje =" + hotel[i].cislo);
                                break;

                            }
                            else

                                Console.WriteLine("Rezervace nebyla vytvořena, vhodný termín nenalezen");
                        }
                    }
                }


                else

                    Console.WriteLine("Pokoj s vhodnou kapacitou nenalezen");

            }

        }


        public void vytvorRezervaci2(Objednavka o)
        {
            Room nalezenyPokoj = najdiVhodnyPokoj(o);

            // tmto pristupem (kdy porovnavam pokoj s null) jsem ztratil informaci o tom, jesli neexistuje vhodn pokoj nebo byly vsechny plne
            if (nalezenyPokoj == null)
            {
                Console.WriteLine("Rezervace nebyla vytvořena");
                return;
            }


            Rezervace r = new Rezervace(o.Jmeno, o.Zacatek, o.Konec);
            nalezenyPokoj.rezervace.Add(r);
            Console.WriteLine("Rezervace vytvořena, Cislo pokoje =" + nalezenyPokoj.cislo);

        }

        public Room najdiVhodnyPokoj(Objednavka o)
        {
            for (int i = 0; i < hotel.Count; i++)
            {
                // tady jsem použil continue, aby se vzhnul jedne urovni zanožení, abych nemusel dat kod hledani terminu pod if
                if (hotel[i].kapacita != o.pozadovanaKapacita)
                {
                    continue;
                }

                bool pokojJeVhodny = true;
                List<Rezervace> rezervaceList = hotel[i].rezervace;
                for (int j = 0; j < rezervaceList.Count; j++)
                {
                    bool nekoliduje = nekolidujeObjednavkaARezervaceNaPokoji(o, rezervaceList[i]);
                    if (!nekoliduje)
                    {
                        pokojJeVhodny = false;
                        break;
                    }
                }
                // teprvé potom, co jsme prošli všechny rezervace na kokoj a ani jedna nekolidovala, víme že pokoj je vhodný a vrátím jej
                if (pokojJeVhodny)
                {
                    return hotel[i];
                }
            }
            //to že jsme nenašli vhodný pokoj dáme najevo tím, že místo určitého pokoje vrátíme null
            return null;
        }



        private bool nekolidujeObjednavkaARezervaceNaPokoji(Objednavka o, Rezervace rezervace)
        {
            // jsem asi předtim tu podminku pro nekolidujici objednavku nevymslilel dobře
            return o.Konec < rezervace.Zacatek || o.Zacatek > rezervace.Konec;
        }
    }
}
