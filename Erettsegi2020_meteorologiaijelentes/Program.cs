
namespace Erettsegi2020_meteorologiaijelentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("tavirathu13.txt");

            List <metJelentes> adatLista = new List<metJelentes>();

            adatLista = beolvas.Select(sor => new metJelentes(sor)).ToList();

            Console.WriteLine("2. feladat");
            Console.Write("Adja meg egy település kódját! Település: ");
            string beVarosKod = Console.ReadLine();

            var utolsoMeresAdat = adatLista.Where(e => e.telepules == beVarosKod).Select(adat => adat.idoString()).OrderBy(ido => ido).Last();

            Console.WriteLine($"Az utolsó mérési adat a megadott településről {utolsoMeresAdat}-kor érkezett.");

            Console.WriteLine("3.feladat");

            var legkisebb = adatLista.Where(a => a.homerseklet == adatLista.Min(x => x.homerseklet)).Last();

            var legnagyobb = adatLista.Where(a => a.homerseklet == adatLista.Max(x => x.homerseklet)).Last();

            Console.WriteLine($"A legalacsonyabb hőmérséklet: {legkisebb.telepules} {legkisebb.idoString()} {legkisebb.homerseklet} fok");

            Console.WriteLine($"A legmagasabb hőmérséklet: {legnagyobb.telepules} {legnagyobb.idoString()} {legnagyobb.homerseklet} fok");

        }
    }
}
