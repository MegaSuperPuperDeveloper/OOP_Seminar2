public interface iMarketBehaviour // Интерфейс для входа и выхода из магазина
{
    void AcceptToMarket(iActorBehaviour actor);
    void ReleaseFromMarket(List<iActorBehaviour> actor);
    void updateOrder();
    void updateReturn();
}