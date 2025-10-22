namespace Erettsegi_2025okt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("ut.txt");

            List <Adatok> adatok = new List <Adatok>();

            int teljesUt = int.Parse(sorok[0]);

            for(int i = 1; i < sorok.Length; i++)
            {
                adatok.Add(new Adatok(sorok[i]));
            }

            Console.WriteLine("2.feladat");
            Console.WriteLine();



        }
    }
}
