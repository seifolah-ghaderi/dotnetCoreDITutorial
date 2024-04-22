using Infrastructure;
using Tools;

namespace Domain
{
    public class Product
    {
        public void Process()
        {
            SeifLogger logger = new SeifLogger();
            SeifDatabase dba = new SeifDatabase();

            logger.Log("starting process data ..");
            Console.WriteLine("start process data");
            var lists = dba.GetProducts();

            dba.AddProducts("new item");

            logger.Log("Finish processing. ");
        }
    }
}