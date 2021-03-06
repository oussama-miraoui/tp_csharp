using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire
{
    class Compte
    {
        private static int num = 0;
        private int numCpt;
        private double solde;
        private Client titulaire;
        
        public Compte()
        {
            this.numCpt = num;
        }
        public Compte(double s, Client t)
        {
            this.numCpt = ++num;
            this.solde = s;
            this.titulaire = t;
        }
        public void Print()
        {
            Console.WriteLine("NumCpt:"+this.numCpt+ ", solde: "+this.solde);
        }
        public void Crediter(double mt)
        {
            if (mt > 0)
            {
                this.solde += mt;
            }
        }
        public void Debiter(double mt)
        {
            if (this.solde >= mt)
            {
                this.solde -= mt;
            }
        }

        public void Virement(Compte cpt, double mt)
        {
            this.Debiter(mt);
            cpt.Crediter(mt);
        }
    }
}
