public interface iActorBehaviour {
    public bool isTakeOrder();
    public bool isMakeOrder();
    public void setTakeOrder(bool isCreated);
    public void setMakeOrder(bool isCreated);
    public Actor getActor();
}