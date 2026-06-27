public class ShopItem
{
    private int _minLevel;
    private int _pointCost;
    private string _description;
    private bool _isPurchased;

    public ShopItem(int lvl, int cost, string desc)
    {
        _minLevel = lvl;
        _pointCost = cost;
        _description = desc;
        _isPurchased = false;
    }

    public int GetPointCost() { return _pointCost; }
    public string GetDescription() { return _description; }

    public string GetStringRepresentation()
    {
        return $"{_minLevel},{_pointCost},{_description}";
    }

    public void DisplayItem()
    {
        string status = _isPurchased ? "[Owned]" : "";
        Console.WriteLine($"  {_description} | Cost: {_pointCost} pts | Min Level: {_minLevel} {status}");
    }

    public bool BuyItem(User u)
    {
        if (u.GetLevel() < _minLevel)
        {
            Console.WriteLine($"You need to be level {_minLevel} to buy this. You are level {u.GetLevel()}.");
            return false;
        }
        if (_isPurchased)
        {
            Console.WriteLine("You already own this item.");
            return false;
        }
        bool spent = u.SpendPoints(_pointCost);
        if (spent)
        {
            _isPurchased = true;
            Console.WriteLine($"You purchased: {_description}!");
            return true;
        }
        return false;
    }
    public bool UseItem()
    {
        if (!_isPurchased)
        {
            Console.WriteLine("You don't own this item yet.");
            return false;
        }
        Console.WriteLine($"You used: {_description}! Enjoy your reward!");
        _isPurchased = false;
        return true;
    }
}