using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valecnici
{
    public class Kouzelnik : Postava
    {

        //new public int SilaUtoku { get; set; } nadbytecne

        override public void ZautocNaVsechny(Postava druhaPostava, Postava tretiPostava)
        {
            Console.WriteLine(Jmeno + " zautocil kouzlem na" + druhaPostava.Jmeno + tretiPostava.Jmeno);

            base.ZautocNaVsechny(druhaPostava, tretiPostava);
            //druhaPostava.PocetZivotu = druhaPostava.PocetZivotu - SilaUtoku;
            //tretiPostava.PocetZivotu = tretiPostava.PocetZivotu - SilaUtoku;           

        }

        override public void ZautocNa(Postava druhaPostava)
        {
            Console.WriteLine(Jmeno + " zautocil kouzlem na " + druhaPostava.Jmeno);
            druhaPostava.PocetZivotu = druhaPostava.PocetZivotu - SilaUtoku;
        }

        public Kouzelnik(string jmeno, int SilaUtoku) : base(jmeno, SilaUtoku) //jmeno predame konstruktoru predka, coz je Postava. A ta uz kod na ulozeni jmena do property Jmeno ma 
        //public Kouzelnik(string jmeno, int SilaUtoku) : base(jmeno, 9)
        {
        }

    }
}
