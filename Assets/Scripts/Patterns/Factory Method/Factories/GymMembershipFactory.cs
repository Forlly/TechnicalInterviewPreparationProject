
public class GymMembershipFactory : MembershipFactory
{
    private readonly float _price;
    private readonly string _description;

    public GymMembershipFactory(float price, string description)
    {
        _price = price;
        _description = description;
    }

    public override IMembership GetMembership()
    {
        GymMembership membership = new GymMembership(_price)
        {
            Description = _description
        };

        return membership;

    }
}
