public abstract class Actor : iActorBehaviour, iReturnOrder // Шаблон для разных видов клиентов
{
    protected String name;
    protected internal bool isTakeOrder;
    protected internal bool isMakeOrder;
    protected internal bool isTakeReturn;
    protected internal bool isMakeReturn;

    /**
     * Инициализация
     */
    public Actor(String name) {
        this.name = name;
    }

    public abstract String getName();
    public abstract void setName(String name);

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

    bool iReturnOrder.isTakeReturn()
    {
        return isTakeReturn;
    }

    bool iReturnOrder.isMakeReturn()
    {
        return isMakeReturn;
    }

    public void setTakeReturn(bool isCreated)
    {
        isTakeReturn = isCreated;
    }

    public void setMakeReturn(bool isCreated)
    {
        isTakeReturn = isCreated;
    }

    public Actor getActor()
    {
        return this;
    }
}