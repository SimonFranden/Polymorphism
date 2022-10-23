namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri[] shapes = {new Rektangel(), new Cirkel(), new Fyrkant(), new Elips(), new Paralellogram()};

            for (int i = 0; i < shapes.Length; i++)
            {              
                Console.WriteLine($"Area {shapes[i].GetType().Name}: {shapes[i].Area()}");
            }

            


        }
    }
}