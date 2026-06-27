public class User
{
    private string _username;
    private int _level;
    private int _xp;
    private int _points;
    private List<ShopItem> _shopList;

    public User(string name)
    {
        _username = name;
        _level = 1;
        _xp = 0;
        _points = 0;
        _shopList = new List<ShopItem>();
    }

    public int GetLevel() { return _level; }
    public void SetLevel(int lvl) { _level = lvl; }
    public int GetXP() { return _xp; }
    public int GetPoints() { return _points; }
    public string GetUsername() { return _username; }

    public void AddXP(int amount)
    {
        if (_xp + amount >= 100)
        {
            SetLevel(_level + 1);
            _xp = _xp + amount - 100;
            Console.WriteLine($"Level up! You are now level {_level}!");
        }
        else
        {
            _xp += amount;
        }
    }

    public void AddPoints(int pts)
    {
        _points += pts;
    }

    public bool SpendPoints(int pts)
    {
        if (_points >= pts)
        {
            _points -= pts;
            return true;
        }
        else
        {
            Console.WriteLine($"Not enough points. You need {pts} but only have {_points}.");
            return false;
        }
    }

    public void AddShopItem(ShopItem item)
    {
        _shopList.Add(item);
    }

    public void CreateShopItem()
    {
        Console.Write("Enter a description for your reward: ");
        string desc = Console.ReadLine();

        Console.Write("Enter the point cost: ");
        int cost = int.Parse(Console.ReadLine());

        Console.Write("Enter the minimum level required (1 for no requirement): ");
        int lvl = int.Parse(Console.ReadLine());

        _shopList.Add(new ShopItem(lvl, cost, desc));
        Console.WriteLine("Reward added to your shop!");
    }

    public void DisplayShopList()
    {
        Console.WriteLine($"\n--- Shop --- (Your points: {_points} | Level: {_level})");
        if (_shopList.Count == 0)
        {
            Console.WriteLine("No items in the shop yet.");
            return;
        }
        for (int i = 0; i < _shopList.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _shopList[i].DisplayItem();
        }
    }

    public void SaveUserData(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_username);
            sw.WriteLine(_level);
            sw.WriteLine(_xp);
            sw.WriteLine(_points);
            foreach (ShopItem item in _shopList)
            {
                sw.WriteLine(item.GetStringRepresentation());
            }
        }
    }

    public static User LoadUserData(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        User u = new User(lines[0]);
        u.SetLevel(int.Parse(lines[1]));
        u._xp = int.Parse(lines[2]);
        u._points = int.Parse(lines[3]);
        for (int i = 4; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(",");
            int lvl = int.Parse(parts[0]);
            int cost = int.Parse(parts[1]);
            string desc = parts[2];
            u.AddShopItem(new ShopItem(lvl, cost, desc));
        }
        return u;
    }

    public bool BuyItemAtIndex(int index)
    {
        if (index < 0 || index >= _shopList.Count)
        {
            Console.WriteLine("Invalid item number.");
            return false;
        }
        return _shopList[index].BuyItem(this);
    }
    public bool UseItemAtIndex(int index)
    {
        if (index < 0 || index >= _shopList.Count)
        {
            Console.WriteLine("Invalid item number.");
            return false;
        }
        return _shopList[index].UseItem();
    }
}