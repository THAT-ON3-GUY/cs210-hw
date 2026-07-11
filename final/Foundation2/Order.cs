using System;
using System.Collections.Generic;
using System.Text;
public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Customer Customer
    {
        get { return _customer; }
    }

    public List<Product> Products
    {
        get { return _products; }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.Price * product.Quantity;
        }

        if (_customer.IsInUnitedStates())
        {
            totalCost *= 1.07; // Apply 7% tax for US customers
        }
        else
        {
            totalCost *= 1.15; // Apply 15% tax for international customers
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in _products)
        {
            packingLabel.AppendLine($"Product: {product.Name}, ID: {product.Id}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder();
        shippingLabel.AppendLine($"Customer: {_customer.Name}");
        shippingLabel.AppendLine($"Address: {_customer.Address.GetFullAddress()}");
        return shippingLabel.ToString();
    }
}