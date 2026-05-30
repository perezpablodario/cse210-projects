using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total = total + product.GetTotalCost();
        }

        if (_customer.LiveInUsa())
        {
            total = total + 5.0;
        }
        else
        {
            total = total + 35.0;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "---PAKING---\n";

        foreach (Product product in _products)
        {
            label = label + $"Product: {product.GetName()} // Id: {product.GetProductId()} // quantity: {product.GetProductQuantity()} \n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "---SHIPPING---\n";
        label = label + $"Customer: {_customer.GetName()}\n";
        label = label + _customer.GetAddress().GetFullAddress() + "\n";

        return label;
    }
}