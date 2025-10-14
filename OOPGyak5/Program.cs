namespace OOPGyak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monitor m1 = new Monitor("VGA");

            Monitor m2 = new Monitor("SVGA", 14.0);

            Monitor m3 = new Monitor(640, 480, 14);

            Console.WriteLine(m2.atlo);

            Console.WriteLine(m1.atlo);

            Console.WriteLine(m3.felbontas);

        }
    }
}
