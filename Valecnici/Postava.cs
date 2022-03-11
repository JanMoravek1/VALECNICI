using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valecnici
{   
    public class Postava
    {
        public string Jmeno { get; set; }
        public int PocetZivotu { get; set; }
        public int SilaUtoku { get; set; }

        virtual public void ZautocNaVsechny(Postava druhaPostava, Postava tretiPostava)
        {
            druhaPostava.PocetZivotu = druhaPostava.PocetZivotu - SilaUtoku;
            tretiPostava.PocetZivotu = tretiPostava.PocetZivotu - SilaUtoku;
            //Console.WriteLine(Jmeno + " zautocil");
        }

        virtual public void ZautocNa(Postava druhaPostava)
        {
            Console.WriteLine(Jmeno + " zautocil na " + druhaPostava.Jmeno);
        }

        public Postava(string jmeno, int SilaUtoku)
        {
            this.Jmeno = jmeno;
            this.SilaUtoku = SilaUtoku; // diky this budeme prirazovat do property, this znamena reference na kontretni instanci Postavy
            PocetZivotu = 20;
        }
    }
}
