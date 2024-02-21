class Program
{
    static void Main()
    {
        Market magnit = new Market();
        Market magnit2 = new Market();
        Actor client1 = new OrdinaryClient("Nikolay");
        Actor client2 = new OrdinaryClient("Sofia");
        Actor client3 = new SpecialClient("Putin", 1);
        TaxInspector client4 = new TaxInspector();
        Actor client5 = new AuctionСlient("Аукционер", 2);
        
        magnit.AcceptToMarket(client1);
        magnit2.AcceptToMarketForReturn(client2);
        magnit2.AcceptToMarketForReturn(client3);
        magnit.AcceptToMarket(client4);
        magnit.AcceptToMarket(client5);
        magnit.updateOrder();
        magnit2.updateReturn();

    }
}