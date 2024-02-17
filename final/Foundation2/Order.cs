
using System.Runtime.InteropServices;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        this._customer = customer;
        this._products = new List<Product>();
    }

    public double TotalCost()
    {
        double sum = 0;

        foreach (Product p in _products)
        {
            sum += p.TotalCost();
        }

        sum += GetShippingCost();

        return sum;
    }


    public double GetShippingCost()
    {
        if (_customer.InUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string GetPackingLabel()
    {
        string packing = "";

        foreach(Product p in _products)
        {
            packing += p.GetProductLabel();
            packing += "\n";
        }

        return packing;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomerDetails();
    }

    public void AddProduct(Product product)
    {
        this._products.Add(product);
    }
}