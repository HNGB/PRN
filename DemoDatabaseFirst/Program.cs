using DemoDatabaseFirst.Models;
namespace EFc.Se1621;
public class Program
{
    public static void Main()
    {
       // 1. init DBContext
            FptEduStoreContext db = new FptEduStoreContext();
        //2. load data 
        foreach (var p in db.Products)
        {
            Console.WriteLine($"Product ID: {p.ProductId}, Product Name: {p.ProductName}");
        }
        Console.ReadLine();
    }
}