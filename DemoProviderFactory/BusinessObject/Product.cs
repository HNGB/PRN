namespace Prn.Se1621;

public class Product
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public int? CategoryId { get; set; }
    public double? Price { get; set; }
    public Product() { }
    public Product(int iD, string prodcutName, int? categoryId, double? price)
    {
        Id = iD;
        ProductName = prodcutName;
        CategoryId = categoryId;
        Price = price;
    }
    public override string? ToString() => $"[Prodcut ID]: {Id}, " + $"[ProdcutName]: {ProductName}, " +
        $"[Category]: {CategoryId}, " + $"[Price]: {Price}";

}