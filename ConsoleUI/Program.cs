using Domain;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var product = new Product();

            product.Process();

            Console.ReadLine();
        }
    }
}