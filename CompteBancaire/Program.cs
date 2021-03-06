using System;

namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Client clt = new Client("Miraoui", "Oussama", "Casa");
            Compte cpt = new Compte(4000,clt);
            Compte cpt2 = new Compte(4000, clt);


            //Console.WriteLine("Apres depot: ");
            //cpt.Crediter(400);
            //cpt.Print();

            //Console.WriteLine("Apres retrait: ");
            //cpt.Debiter(3000);
            //cpt.Print();

            cpt.Virement(cpt2, 2000);
            cpt.Print();
            cpt2.Print();

        }
    }
}
