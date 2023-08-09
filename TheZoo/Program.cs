namespace TheZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Zoo World!");
            Lion lion = new Lion();
            Jaguar jaguar = new Jaguar("Gold", 30, "Jamar the Jaguar");
            Console.WriteLine($"My name is {jaguar.name} and my spots color are {jaguar.color} and I have {jaguar.teeth} teeth");
            Chimp chimp = new Chimp();
            Silverback silverback = new Silverback();
            BlackMamba blackMamba = new BlackMamba();
            KomodoDragon komodoDragon = new KomodoDragon();
        }

    }
}