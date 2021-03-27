using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class CompteEpargne : Compte
    {
        private double TauxInteret;

        public CompteEpargne(Client cl, MAD solde, double TI)
            : base(cl, solde)
        {
            while(this.TauxInteret <= 0 && this.TauxInteret >= 100)
            {
                 this.TauxInteret = Convert.ToDouble(Console.ReadLine());
            }
            this.TauxInteret = TI;
        }
        public void CalculInteret()
        {
            this.solde = (this.solde * this.TauxInteret) / 100;
        }
        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Le taux d'intérêt est : " + this.TauxInteret);
        }
    }
}
