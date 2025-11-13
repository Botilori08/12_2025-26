
namespace Erettsegi2020_meteorologiaijelentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("tavirathu13.txt");

            List <metJelentes> adatLista = new List<metJelentes>();

            adatLista = beolvas.Select(sor => new metJelentes(sor)).ToList();

            Console.Write("Adja meg egy település kódját! Település: ");
            string beVarosKod = Console.ReadLine();

            var utolsoMeresAdat = adatLista.Where(e => e.telepules == beVarosKod).Select(adat => adat.ido).OrderBy(ido => ido).Last();

            Console.WriteLine($"Az utolsó mérési adat a megadott településről -kor érkezett.");


        }
    }
}
