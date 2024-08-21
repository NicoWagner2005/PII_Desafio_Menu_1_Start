namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    public string name;
    public string Name(value)       //nombre del platillo
    {
        get {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int price;
    public int Price(value)     //precio del platillo
    {
        get {
            return price;
        }
        set
        {
            price = value;
        }
    }

    public bool vegetarian;
    public string IsVegetarian(value)    //es vegetariano?  el valor 'vegetariano' es booleano, si es true IsVegetarian devuelve "yes"
    {                                       // si es false devuelve "no"
        get {
            return vegetarian;
        }
        set
        {
            if (vegetarian)
            {
                return "yes";
            }
            else
            {
                return "no";
            }
        }
    }

    public Dish(string name, int price, bool vegetarian)      //constructor
    {
        this.Name = name;
        this.Price = price;
        this.IsVegetarian = vegetarian;
    }
}