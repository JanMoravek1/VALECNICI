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
                Room pokoj = new Room();
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


        public void vytvorRezervaci (Objednavka o)
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
                                    if (o.Zacatek < hotel[i].rezervace[y].Zacatek && o.Konec < hotel[i].rezervace[y].Konec)
                                    {
                                        Rezervace r = new Rezervace(o.Jmeno, o.Zacatek, o.Konec);
                                        hotel[i].rezervace.Add(r);
                                        Console.WriteLine("Rezervace vytvořena, Cislo pokoje =" + hotel[i].cislo);
                            break ;
                                
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




    }
    
}
