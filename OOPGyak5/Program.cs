namespace OOPGyak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Október_23 oktober23 = new Október_23();

            oktober23.Rendezo = "Kovács Máté";
            oktober23.Nev = "Október 23 ünnepély";
            oktober23.Zajlik();
            oktober23.Szereplok = new List<string> { "Taki", "John Smith" };
            Console.WriteLine(oktober23.ToString());


        }
    }
}
