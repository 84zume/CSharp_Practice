public class Product
{
    public int Code { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

    public int GetTax(){
        return (int)(Price * 0.08);
    }

    public int GetPriceIncludingTax(){
        return Price + GetTax();
    }
}