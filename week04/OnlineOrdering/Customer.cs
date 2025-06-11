using System;
using System.Collections.Generic;
public class Customer
{
    private string _name;
    private Address _address;
    private List<string> _names = new List<string>
    {
        "John Miller", "Jean Dupont"
    };
    public Customer(int index)
    {
        _name = _names[index];
        _address = new Address(index);
    }
    public bool American ()
    {
        return _address.InAmerica();
    }
    public string GetName()
    {
        return _name;
    }
    
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}