
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

            var legkisebb = adatLista.Where(a => a.homerseklet == adatLista.Min(x => x.homerseklet)).First();//.FirstOrDefault(new metJelentes("   0"));

            var legnagyobb = adatLista.Where(a => a.homerseklet == adatLista.Max(x => x.homerseklet)).First();//.FirstOrDefault(new metJelentes("   0"));

            //Console.WriteLine($"A legalacsonyabb hőmérséklet: {legkisebb.telepules} {legkisebb.idoString()} {legkisebb.homerseklet} fok");

            //Console.WriteLine($"A legmagasabb hőmérséklet: {legnagyobb.telepules} {legnagyobb.idoString()} {legnagyobb.homerseklet} fok");

            //másik megoldás
            var rendezett = adatLista.OrderBy(adat => adat.homerseklet);

            Console.WriteLine($"A legalacsonyabb hőmérséklet: {rendezett.First().telepules} {rendezett.First().idoString()} {rendezett.First().homerseklet} fok \r\nA legmagasabb hőmérséklet: {rendezett.Last().telepules} {rendezett.Last().idoString()} {rendezett.Last().homerseklet} fok");

            Console.WriteLine("4.feladat");

            var csendesek = adatLista.Where(adat => adat.szelcsend()).Select(adat => adat.telepules +" "+adat.idoString());

            Console.WriteLine(string.Join("\n", csendesek));


            
            

        }
    }
}
