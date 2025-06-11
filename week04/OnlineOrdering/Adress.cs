using System;
using System.Collections.Generic;
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private List<string> _possibleCountries = new List<string>
    {
        "USA", "France"
    };
    private List<string> _possibleStreets = new List<string>
    {
        "1050 Pine Hill Drive", "12 Rue de la Liberté"
    };
    private List<string> _possibleCities = new List<string>
    {
        "Austin","Paris"
    };
    private List<string> _possibleStates = new List<string>
    {
        "Texas","Paris"
    };
    public Address (int index)
    {
        _street = _possibleStreets[index];
        _city = _possibleCities[index];
        _state = _possibleStates[index];
        _country = _possibleCountries[index];
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
    public bool InAmerica()
    {
        return _country == _possibleCountries[0];
        
    }
}