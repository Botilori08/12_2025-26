using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace Shakespeare_regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string forras = File.ReadAllText("forras.txt");

            Regex rg = new Regex(@"[A-ZÖÜÓŐÚÉÁŰÍ-]{2,}\s[A-ZÖÜÓŐÚÉÁŰÍ-]{2,}\b|[A-ZÖÜÓŐÚÉÁŰÍ-]{2,}\b");
            var eredmeny = rg.Matches(forras);

            /*Console.WriteLine(eredmeny.Count);
            Console.WriteLine();*/

            foreach (Match match in eredmeny)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
