using System;
using System.Collections.Generic;
using System.Text;

namespace Valecnici
{
    public class Karta
    {
        public string druh { get; set; }
        public string barva { get; set; }
        public int hodnota { get; set; }

        public Karta(string druh, string barva, int hodnota)
        {
            this.druh = druh;
            this.barva = barva;
            this.hodnota = hodnota;

        }

        public override string ToString()
        {
            return barva + " " + druh;
        }
    }
}
