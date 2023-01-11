
public class PersonalTrainingMembership : IMembership
{
    private readonly string _name;
    private readonly float _price;

    public PersonalTrainingMembership(float price)
    {
        _name = "Personal training membership";
        _price = price;
    }

    public string Name => _name;
    public string Description { get; set; }

    public float GetPrice() => _price;
}
