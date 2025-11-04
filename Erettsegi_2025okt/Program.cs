namespace Erettsegi_2025okt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("ut.txt");

            List <Adatok> adatok = new List <Adatok>();


            int teljesUt = int.Parse(sorok[0]);

            bool varosban = false;

            for(int i = 1; i < sorok.Length; i++)
            {
                adatok.Add(new Adatok(sorok[i]));
                adatok[i - 1].isTelepules();
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







        }
    }
}
