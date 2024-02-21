public class AuctionСlient : SpecialClient // Аукционный клиент
{

    private static int count = 0; // Количество участников акций
    
    public AuctionСlient(string name, int idVip) : base(name, idVip) // Инициализация
    {
        count++;
    }
    
    public int getCount() // Получение количества участников акций
    {
        return count;
    }

}