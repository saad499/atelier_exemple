using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class MAD
    {
        private double valeur;
        
        public MAD(double v)
        {
            this.valeur = v;
        }

        public MAD()
        {
        }

        public void print()
        {
            Console.WriteLine("La valeur est : " + this.valeur + "MAD");
        }

        public static MAD operator +(MAD M, MAD N)
        {
            MAD mm = new MAD(0);
            mm.valeur = M.valeur + N.valeur;
            return mm;
        }
        public static MAD operator -(MAD M, MAD N)
        {
            MAD mm = new MAD(0);
            mm.valeur = M.valeur - N.valeur;
            return mm;
        }
        public static MAD operator >(MAD M, MAD N)
        {
            MAD mm = new MAD(0);
            mm.valeur = M.valeur > N.valeur;
            return mm;
        }
        public static MAD operator * (MAD m1, double m2)
        {
            MAD m = new MAD(0);
            m.valeur = m1.valeur * m2;
            return m;
        }
        public static MAD operator / (MAD m1, double m2)
        {
            MAD mm = new MAD(0);
            mm.valeur = m1.valeur / m2;
            return mm;
        }
        public MAD Plus(MAD M)
        {
            MAD mm = new MAD(0);
            mm.valeur = valeur + M.valeur;
            return mm;
        }
        public MAD Moins(MAD M)
        {
            MAD mm = new MAD(0);
            mm.valeur = valeur + M.valeur;
            return mm;
        }
        public MAD egal(MAD M)
        {
            valeur = M.valeur;
            return this;
        }
        public bool superieur(MAD m)
        {
            return valeur > m.valeur;
        }

        public bool inferieur(MAD m)
        {
            return valeur < m.valeur;
        }
    }
}
