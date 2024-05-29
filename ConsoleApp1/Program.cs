namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals= new List<Animal>();
            Donkey d1 = new Donkey("d1", 1);animals.Add(d1);
            Donkey d2 = new Donkey("d2", 2); animals.Add(d2);

            foreach (Animal animal in animals)
            {
                animal.SayName();animal.SayValue();

            }

            //Console.WriteLine(animals);
        }
    }
}
