using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Listás_01_16
{
    internal class Szamok
    {
        List<int> szamok;

        public Szamok(int[] szamok)
        { 
            this.szamok = new List<int>(szamok);
        }

        public static Szamok operator+(Szamok egyik, int masik)
        {
            List<int> szamok = new List<int>(egyik.szamok);
            szamok.Add(masik);
            return new Szamok(szamok.ToArray());
        }

        public static Szamok operator+(Szamok egyik, Szamok masik)
        {
            var szamok = new List<int>(egyik.szamok);

            foreach(int szam in masik.szamok)
            {
                szamok.Add(szam);
            }
            return new Szamok(szamok.ToArray());
        }
        public static int operator+(int szam, Szamok szamok)
        {
            /*
            int osszeg = 0;
            foreach(int egySzam in szamok.szamok)
            {
                osszeg += egySzam;
            }*/
            return szam + szamok.szamok.Sum();
        }



        public override string ToString()
        {
            return string.Join(", ",this.szamok);
        }

    }
}
