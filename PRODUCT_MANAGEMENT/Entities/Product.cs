namespace Prn.Se1621;
public class Product
{
    private int _id;
    private string _productName;

    
    
    //Expression-Bodied
    public int Id { get => _id; set => _id = value; }
    public string ProductName { get => _productName; set => _productName = value; }
    public string Desc { get; set; } // .NET 5
    public double UnitPrice { get; set; }
    public DateTime StartDate { get; set; }
    //Contructors
    public Product() { }

    public Product(int id, string productName, string desc, double unitPrice, DateTime startDate)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        UnitPrice = unitPrice;
        StartDate = startDate;
    }

    //override ToString
    public override string? ToString() => $"[Id = {Id}, Product Name = {ProductName}, Desc = {Desc}, unit Price = {UnitPrice}, Start Date = {StartDate}]";
}
