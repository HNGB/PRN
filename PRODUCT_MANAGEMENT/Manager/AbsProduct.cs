namespace Prn.Se1621;

public abstract class AbsProduct
{
    public Product[] Products { set; get; }
    public int Size { set; get; } //so luong phan tu co that

    public AbsProduct()
    {
        Products = new Product[Utils.InitNumberProduct];
        Size = 0;
    }

}