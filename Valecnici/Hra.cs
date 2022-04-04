using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valecnici
{
    public class Hra
    {

        Banker bankerB = new Banker("Banker", 0);
        Hrac hracH = new Hrac("Hrac", 0);

        public void Hrej()

        {

            do

            {
                Console.WriteLine(" Hra Black Jack zacina, prohrava ten kdo se jako prvni dostane pres cislo 21");

                bankerB.Hra ();
                hracH.Hra();      

            } while (bankerB.PocetBodu < 22 && hracH.PocetBodu < 22);

            Console.WriteLine(bankerB.Jmeno + " ma Bodu: " + bankerB.PocetBodu);
            Console.WriteLine(hracH.Jmeno + " ma Bodu: " + hracH.PocetBodu);

            if (bankerB.PocetBodu > 21)
                                Console.WriteLine("Vyhral: " + bankerB.Jmeno);

            else Console.WriteLine("Vyhral: " + hracH.Jmeno);


        }



        
    }
}
