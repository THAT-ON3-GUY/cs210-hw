public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string Name
    {
        get { return _name; }
    }

    public int Id
    {
        get { return _id; }
    }

    public double Price
    {
        get { return _price; }
    }

    public int Quantity
    {
        get { return _quantity; }
    }

    public double GetTotalPrice(Address address)
    {
        double totalPrice = _price * _quantity;
        if (address.InUnitedStates() == true)
        {
            totalPrice += 5; // Add $5 shipping fee for US
        } else
        {
            totalPrice += 35; // Add $35 shipping fee for international
        }
        return totalPrice;
    }
}