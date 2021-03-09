using System;

namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Client clt = new Client("Miraoui", "Oussama", "Casa");
            Client clt2 = new Client("Mehdi", "Hamid", "Fes");


            MAD md = new MAD(40000);
            MAD md1 = new MAD(45000);

            Compte cpt = new Compte(md,clt);
            Compte cpt2 = new Compte(md1, clt);


            //Console.WriteLine("Apres depot: ");
            //MAD montant = new MAD(5000);
            //cpt.Crediter(montant);

            //cpt.Print();

            MAD montant = new MAD(5000);
            cpt.Virement(cpt2, montant);
            cpt.Print();
            cpt2.Print();

        }
    }
}
