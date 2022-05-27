using System;
using System.Collections.Generic;
using Valecnici;
namespace Valecnici

{
    public class Rezervace
    {

        public string Jmeno { get; set; }
        public string Start { get; set; }
        public string End { get; set; }

        public Rezervace(string Jmeno, string Start, string End)
        {
            this.Jmeno = Jmeno;
            this.Start = Start;
            this.End = End;

        }
    }
}
