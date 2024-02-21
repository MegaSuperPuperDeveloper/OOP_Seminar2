public class Market : iMarketBehaviour, iQueueBehaviour // Сам супермаркет 
{

    private List<iActorBehaviour> queue;
    private List<iReturnOrder> queueReturn;

    /**
     * Инициализация списков
     */
    public Market()
    {
        this.queue = new List<iActorBehaviour>();
        this.queueReturn = new List<iReturnOrder>();
    }

    /**
     * Клиент вошел в магазин для оформления заказа и его получения
     */
    public void AcceptToMarket(iActorBehaviour actor)
    {
        Console.WriteLine(actor.getActor().getName() + " клиент пришел в магазин ");
        TakeInQueue(actor.getActor());
    }
    
    /**
     * Клиент пришел в магазин для возврата
     */
    public void AcceptToMarketForReturn(iReturnOrder actor)
    {
        Console.WriteLine(actor.getActor().getName() + " клиент пришел в магазин для возврата товара");
        TakeInQueueReturn(actor.getActor());
    }

    /**
     * Клиент добавлен в очередь за заказом
     */
    public void TakeInQueue(iActorBehaviour actor)
    {
        this.queue.Add(actor.getActor());
        Console.WriteLine(actor.getActor().getName() + " клиент добавлен в очередь ");
    }

    /**
     * Клиент добавлен в очередь за возвратом
     */
    public void TakeInQueueReturn(iReturnOrder actor)
    {
        this.queueReturn.Add(actor.getActor());
        Console.WriteLine(actor.getActor().getName() + " клиент добавлен в очередь на возврат");
    }

    /**
     * Клиент покинул магазин после очереди за заказом
     */
    public void ReleaseFromMarket(List<iActorBehaviour> actors)
    {
        foreach (iActorBehaviour actor in actors)
        {
            Console.WriteLine(actor.getActor().getName() + " клиент ушел из магазина ");
            queue.Remove(actor.getActor());
        }

    }

    /**
     * Клиент поокинул магазин после очереди за возвратом
     */
    public void ReleaseFromMarketQueueReturn(List<iReturnOrder> actors)
    {
        foreach (iReturnOrder actor in actors)
        {
            Console.WriteLine(actor.getActor().getName() + " клиент ушел из магазина ");
            queueReturn.Remove(actor.getActor());
        }

    }

    /**
     * Запуск механизма
     */
    public void updateOrder()
    {
        TakeOrder();
        GiveOrder();
        ReleaseFromQueue();
    }

    public void updateReturn()
    {
        TakeReturn();
        ReturnOrder();
        ReleaseFromQueueReturn();
    }

    /**
     * Клиент получает заказ
     */
    public void GiveOrder()
    {
        foreach (iActorBehaviour actor in queue)
        {
            if (actor.isMakeOrder())
            {
                actor.setTakeOrder(true);
                Console.WriteLine(actor.getActor().getName() + " клиент получил свой заказ ");
            }
        }
    }
    
    /**
     * Клиент получает возврат средств
     */
    public void ReturnOrder()
    {
        foreach (iReturnOrder actor in queueReturn)
        {
            if (!actor.isMakeReturn())
            {
                actor.setTakeReturn(true);
                Console.WriteLine(actor.getActor().getName() + " клиент получил средства за возврат");
            }
        }
    }

    /**
     * Клиент покинул оччередь за заказом
     */
    public void ReleaseFromQueue()
    {
        List<iActorBehaviour> releaseActors = new List<iActorBehaviour>();
        foreach (iActorBehaviour actor in queue)
        {
            if (actor.isTakeOrder())
            {
                releaseActors.Add(actor.getActor());
                Console.WriteLine(actor.getActor().getName() + " клиент ушел из очереди ");
            }
        }

        ReleaseFromMarket(releaseActors);
    }

    /**
     * Клиент ушел из очереди за заказом
     */
    public void ReleaseFromQueueReturn()
    {
        List<iReturnOrder> releaseActors = new List<iReturnOrder>();
        foreach (iReturnOrder actor in queueReturn)
        {
            if (actor.isTakeReturn())
            {
                releaseActors.Add(actor.getActor());
                Console.WriteLine(actor.getActor().getName() + " клиент ушел из очереди ");
            }
        }

        ReleaseFromMarketQueueReturn(releaseActors);
    }

    /**
     * Клиент сделал заказ
     */
    public void TakeOrder()
    {
        foreach (iActorBehaviour actor in queue)
        {
            if (!actor.isMakeOrder())
            {
                actor.setMakeOrder(true);
                Console.WriteLine(actor.getActor().getName() + " клиент сделал заказ ");

            }
        }
    }
    
    /**
     * Клиент получил средства за возврат
     */
    public void TakeReturn()
    {
        foreach (iReturnOrder actor in queueReturn)
        {
            if (!actor.isMakeReturn())
            {
                actor.setMakeReturn(true);
                Console.WriteLine(actor.getActor().getName() + " клиент совершил возврат товара ");

            }
        }
    }
}