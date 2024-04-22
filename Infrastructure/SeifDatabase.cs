namespace Infrastructure
{
    public class SeifDatabase
    {
        public List<string> GetProducts()
        {
            Console.WriteLine("Fecthing data");
            return new List<string>() { "Apple", "BPM", "Simon" };
        }

        public void AddProducts(string product)
        {
            Console.WriteLine("Add new Item");
        }
    }
}