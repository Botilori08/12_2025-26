namespace Erettsegi_2025okt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] sorok = File.ReadAllLines("ut.txt");

			List <Adatok> adatok = new List <Adatok>();


			double teljesUt = double.Parse(sorok[0]);

			bool varosban = false;

			for(int i = 1; i < sorok.Length; i++)
			{
				adatok.Add(new Adatok(sorok[i]));
				if(adatok[i - 1].isTelepules()) varosban = true;
				
				if (adatok[i-1].jelzes == "]") varosban=false;

				adatok[i-1].varosban = varosban;
			}

			Console.WriteLine("2.feladat");

			for(int i = 0; i < adatok.Count; i++)
			{
				if (adatok[i].isTelepules())
				{
					Console.WriteLine(adatok[i].jelzes);
				}
			}

			Console.WriteLine("3.feladat");
			Console.Write("Adja meg a vizsgált szakasz hosszát km-ben! ");
			
			double beKm = Convert.ToDouble(Console.ReadLine());

			for (int i = 0; i < adatok.Count; i++)
			{
				if (adatok[i].km <= beKm*1000)
				{
                    Console.WriteLine(adatok[i].km);
                }
				
			}

            Console.WriteLine("4.feladat");

			int varosKezdet = 0;
			int varosKm = 0;
			for(int i = 0;i < adatok.Count; i++)
			{
				if (adatok[i].isTelepules())
				{
					varosKezdet = adatok[i].km;
				}
				if (adatok[i].jelzes == "]")
				{
					varosKm += adatok[i].km - varosKezdet;
				}
			}

            Console.WriteLine($"Az út {varosKm / teljesUt:0.00%}-a vezet településen belül.");







		}
	}
}
