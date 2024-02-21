public class SpecialClient : Actor // "Вип" клиент
{

    public SpecialClient(string name, int idVip) : base(name)
    {
        this.idVip = idVip;
    }
    
    private int idVip;
    
    public bool isMakeOrder()
    {
        return isMakeOrder();
    }

    public bool isTakeOrder()
    {
        return isTakeOrder();
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