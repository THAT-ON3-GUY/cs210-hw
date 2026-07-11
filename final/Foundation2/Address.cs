public class Address
{
    public string _street { get; set; }
    public string _city { get; set; }
    public string _state { get; set; }
    public string _country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state} {_country}";
    }

    public bool InUnitedStates()
    {
        return _country.ToLower() == "united states";
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}