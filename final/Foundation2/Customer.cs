
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool InUSA()
    {
        return _address.IsUSA();
    }

    public string GetCustomerDetails()
    {
        return _name + "\n" + _address.GetAddressDetails();
    }
}