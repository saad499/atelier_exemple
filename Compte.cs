using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Compte
    {
        private static int cpt;
        private readonly int numcompte;
        private readonly Client titulaire;
        protected MAD solde;
        private static MAD plafond;
        private DateTime dateCreation = DateTime.Now; 

        //constructeur
        static Compte()
        {
            cpt = 0;
            plafond = new MAD(12000);
        }
        public Compte(Client cl, MAD solde)
        {
            cpt++;
            this.numcompte = cpt;
            this.titulaire = cl;
            this.solde = solde;
        }
        public virtual void afficher()
        {
            Console.WriteLine("Le numero de compte : " + this.numcompte);
            this.titulaire.afficher();
            Console.WriteLine("Le solde est : " + this.solde);
            this.solde.print();
        }

        internal void Crediter(object p)
        {
            throw new NotImplementedException();
        }

        public void Crediter(MAD montant)
        {
            if (montant.superieur(new MAD()))
            {
                this.solde.egal(this.solde.Plus(montant));
            }
            else
            {
                Console.WriteLine("Montant non valide");
            }
        }
 
        public void Debiter(MAD montant)
        {
            if (montant.inferieur(new MAD()))
            {
                this.solde.egal(this.solde.Moins(montant));
            }
        }
        public void verser(MAD M1)
        {
            this.Debiter(M1);
            this.Crediter(M1);
        }
   
}
    
}
