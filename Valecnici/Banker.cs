using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valecnici
{
    public class Banker
    {
        public string Jmeno { get; set; }
        public int PocetBodu { get; set; }

        virtual public void Hra()

        {

            Random nh = new Random();
            int cislo = nh.Next(0, 12);

            Console.WriteLine(Jmeno + " vrha kostkou a hodil" + cislo);

            PocetBodu = PocetBodu + cislo;
        }

       // koment


        public Banker (string jmeno, int pocetBodu)
        {
            this.Jmeno = jmeno;
            this.PocetBodu = pocetBodu; // diky this budeme prirazovat do property, this znamena reference na kontretni instanci Postavy

        }
    }
}
