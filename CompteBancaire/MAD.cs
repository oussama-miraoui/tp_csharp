using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire
{
    class MAD
    {
        private double valeur;

        public MAD() { this.valeur = 0; }
        public MAD(double v)
        {
            this.valeur = v;
        }

        public void Print()
        {
            Console.WriteLine("Solde: "+ this.valeur+" MAD");
        }



        public static MAD operator+ (MAD md,MAD md1)
        {
            MAD res = new MAD();
            res.valeur = md.valeur + md1.valeur;
            return res;
        }

        public static MAD operator-(MAD md, MAD md1)
        {
            MAD res = new MAD(md.valeur - md1.valeur);
            return res;
        }
        public static bool operator>=(MAD md, MAD md2)
        {
            if (md.valeur >= md2.valeur)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(MAD md, MAD md2)
        {
            if (md.valeur <= md2.valeur)
            {
                return true;
            }
            return false;
        }
    }
}
