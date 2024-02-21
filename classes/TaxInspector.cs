public class TaxInspector : iActorBehaviour
{
    private String name;
    private bool isTakeOrder;
    private bool isMakeOrder;

    public TaxInspector()
    {
        this.name = "Налоговый инспектор";
    }

    bool iActorBehaviour.isTakeOrder()
    {
        return isTakeOrder;
    }

    bool iActorBehaviour.isMakeOrder()
    {
        return isMakeOrder;
    }

    public void setTakeOrder(bool isCreated)
    {
        isTakeOrder = isCreated;
    }

    public void setMakeOrder(bool isCreated)
    {
        isMakeOrder = isCreated;
    }

    public Actor getActor()
    {
        return new OrdinaryClient("Тайный клиент");
    }
}