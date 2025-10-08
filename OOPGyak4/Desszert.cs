﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyak4
{
	abstract internal class Desszert : IEtel
	{
		private string nev;
		public string Nev {

			get
			{
				return nev;
			}

			set
			{
				nev = value;
			}

		}

		private int energia;
		public int Energia
		{
			get
			{
				return energia;
			}
			set
			{
				if (value < 0)
				{
					energia = 0;
				}
				else
				{
					energia = value;
				}
			}
		}
		abstract public void Elfogyasztas();


	}

} 

