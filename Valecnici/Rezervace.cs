using System;
using System.Collections.Generic;
using Valecnici;
namespace Valecnici

{
    public class Rezervace
    {

        public string Jmeno { get; set; }
        public int Zacatek { get; set; }
        public int Konec { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
       // public Room pridelenyPokoj { get; set; } - je to nutné?

        public Rezervace(string Jmeno, int Zacatek, int Konec)
        {
            this.Jmeno = Jmeno;
            this.Zacatek = Zacatek;
            this.Konec = Konec;

        }
    }
}
