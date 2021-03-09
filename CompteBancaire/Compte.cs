using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire
{
    class Compte
    {
        private static int cpt = 0;
        private int numCpt;
        private Client titulaire;
        private MAD solde;

        public Compte()
        {
            this.numCpt = cpt;
        }
        public Compte(MAD s, Client t)
        {
            this.numCpt = ++cpt;
            this.solde = s;
            this.titulaire = t;
        }
        public void Print()
        {
            this.titulaire.Print();
            Console.WriteLine("NumCpt:" + this.numCpt);
            this.solde.Print();

        }
        public bool Crediter(MAD mt)
        {
            this.solde += mt;
            return true;
        }
        public bool Debiter(MAD mt)
        {
            if (this.solde >= mt)
            {
                this.solde -= mt;
                return true;
            }
            return false;
        }

        public void Virement(Compte cpt, MAD mt)
        {
            if (this.Debiter(mt))
            {
                cpt.Crediter(mt);
            }
        }
    }
}
