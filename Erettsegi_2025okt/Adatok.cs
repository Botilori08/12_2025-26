﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erettsegi_2025okt
{
    internal class Adatok
    {
        public int km;
        public string jelzes;

        public Adatok(string sor)
        {
            string[] vag = sor.Split(' ');
            km = int.Parse(vag[0]);
            jelzes = vag[1];
        }

        public Adatok(int km, string jelzes)
        {
            this.km = km;
            this.jelzes = jelzes;
        }
        
        public bool isTelepules()
        {

        }

    }
}
