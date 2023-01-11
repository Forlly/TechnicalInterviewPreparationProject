
public class PersonalTrainingMembershipFactory : MembershipFactory
{
    private readonly float _price;
    private readonly string _description;

    public PersonalTrainingMembershipFactory(float price, string description)
    {
        _price = price;
        _description = description;
    }

    public override IMembership GetMembership()
    {
        PersonalTrainingMembership membership = new PersonalTrainingMembership(_price)
        {
            Description = _description
        };

        return membership;

    }
}
