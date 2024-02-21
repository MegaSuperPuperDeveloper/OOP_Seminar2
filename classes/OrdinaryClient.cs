public class OrdinaryClient : Actor // Дефолт клиент
{

    public OrdinaryClient(string name) : base(name) {}
    
    public bool isMakeOrder()
    {
        return base.isMakeOrder;
    }

    public bool isTakeOrder()
    {
        return base.isTakeOrder;
    }

    public void setMakeOrder(bool isCreated)
    {
        base.isMakeOrder = isCreated;
    }

    public void setTakeOrder(bool isCreated)
    {
        base.isTakeOrder = isCreated;
    }

    public Actor getActor()
    {
        return this;
    }

    public override string getName()
    {
        return name;
    }

    public override void setName(string name)
    {
        base.name = name;
    }
}