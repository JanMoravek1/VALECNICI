using System;
using System.Collections.Generic;
using Valecnici;
namespace Valecnici
{
    public class RezervacniSystem
    {
        List <Rezervace> rezervace = new List<Rezervace>();


        public void VytvorRezervaci(string Jmeno, string Pocatek, string Konec)
        {

            Rezervace NovaRezervace = new Rezervace(Jmeno, Pocatek, Konec);
            rezervace.Add(NovaRezervace);

        }


        public void VypisRezervace ()
        {

            Console.WriteLine("Jmeno: " + rezervace[0].Jmeno + "Pocatek: " + rezervace[0].Start + "Konec: " + rezervace[0].End);

        }



        public RezervacniSystem()
        {
        }
    }
}
