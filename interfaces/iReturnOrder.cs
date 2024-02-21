public interface iReturnOrder {
    public bool isTakeReturn();
    public bool isMakeReturn();
    public void setTakeReturn(bool isCreated);
    public void setMakeReturn(bool isCreated);
    public Actor getActor();
}