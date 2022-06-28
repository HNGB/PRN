namespace Prn.Se1621;
using static System.Console;
 public class Program
{
    public static void Main()
    {
        Product p = new Product();
        p.Id = 1;
        p.ProductName = "Laptop Dell";
        p.Desc = "San pham moi nhat 2022";
        p.UnitPrice = 1500;
        p.StartDate = DateTime.Now;


        ProductManagement  productManagement = new ProductManagement();
        productManagement.Add(p);
        productManagement.Add(new Product(2, "Macbook Pro 12", "Mac manh nhat", 2500, new DateTime(year: 2022, month: 5, day: 23)));
        productManagement.Add(new Product(3, "Asus", "Asus manh nhat", 2500, new DateTime(year: 2022, month: 5, day: 23)));
        productManagement.Display();

        ReadLine();
    }
}