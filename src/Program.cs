using Ucu.Poo.Restaurant;

public class Program
{
    static void Main()
    {
        Dish d1 = new Dish("Milanesa", 100, false);
        Menu m1 = new Menu();
        
        m1.AddDish(d1);
    }
}
