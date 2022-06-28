

namespace Prn.Se1621;
 public interface IProduct
{
    void Add(Product p);
    void Update(Product p);
    Product Get(Product p);
    bool Delete(Product p);
    void Display();
    Product[] GetAllProductByUnitPrice(double price);
}
