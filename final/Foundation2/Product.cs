
public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity = 0;

    public Product(string name, string productID, double price, int quantity)
    {
        this._name = name;
        this._productID = productID;
        this._price = price;
        this._quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductLabel()
    {
        return _name + " " + _productID;
    }

}