using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire
{
    class Client
    {
        private string nom, prenom, adresse;

        public Client() { }
        public Client(string n, string p, string a) 
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
        }
    }
}
