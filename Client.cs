using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;

        public Client(string n,string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
        }
        public void afficher()
        {
            Console.WriteLine("Le nom : " + this.nom);
            Console.WriteLine("Le prenom : " + this.prenom);
            Console.WriteLine("Le adresse : " + this.adresse);
        }
    }
}
