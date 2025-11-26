namespace Jelado
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List <Adat> adatok = new List <Adat> ();

			string[] sorok = File.ReadAllLines("jel.txt");
		
			sorok.ToList().ForEach(sor => adatok.Add(new Adat(sor)));
	
			adatok = sorok.ToList().Select(x => new Adat(x)).ToList();

        }
	}
}
