
public class GymPlusPoolMembershipFactory : MembershipFactory
{
    private readonly float _price;
    private readonly string _description;

    public GymPlusPoolMembershipFactory(float price, string description)
    {
        _price = price;
        _description = description;
    }

    public override IMembership GetMembership()
    {
        GymPlusPoolMembership membership = new GymPlusPoolMembership(_price)
        {
            Description = _description
        };

        return membership;

    }
}
