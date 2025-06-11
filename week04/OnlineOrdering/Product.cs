using System;
using System.Collections.Generic;
public class Product
{
    private string _product;
    private int _id;
    private double _price;
    private int _quantity;
    private List<string> _productList = new List<string>
    {
        "Keybord K9T", "Mouse L42", "USB Mini-fan", "Headset Gamer Pro 9000", "PSU 600W Silver"
    };
    private List<int> _idList = new List<int>
    {
        1,2,3,4,5
    };
    private List<double> _priceList = new List<double>
    {
        29.99,20.50,5.49,39.99,35.99
    };
    public Product(int index)
    {
        _product = _productList[index];
        _id = _idList[index];
        _price = _priceList[index];
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
    public string GetLabel()
    {
        return $"\nProduct: {_product}\nID: {_id}\nQuantity: {_quantity}\n";
    }
}