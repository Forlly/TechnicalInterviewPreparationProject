
public class GymMembership : IMembership
{
    private readonly string _name;
    private readonly float _price;

    public GymMembership(float price)
    {
        _name = "Gym membership";
        _price = price;
    }

    public string Name => _name;
    public string Description { get; set; }

    public float GetPrice() => _price;
}
