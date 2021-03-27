using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class CompteCourant : Compte
    {
        private MAD decouvert;

        public CompteCourant(Client cl, MAD solde,)
            :base(cl, solde)
        {
            this.decouvert = solde;
        }

        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Le decouvert est : ");
            this.decouvert.print();
        }
    }
}
