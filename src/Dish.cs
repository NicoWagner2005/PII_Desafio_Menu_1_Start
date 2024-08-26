namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    public string name;
    public string Name       //nombre del platillo
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
    public int Price     //precio del platillo
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
    public string IsVegetarian    //es vegetariano?  el valor 'vegetariano' es booleano, si es true IsVegetarian devuelve "yes"
    {                                       // si es false devuelve "no"
        get 
        {
            return vegetarian.ToString();
        }
        set
        {
            if (value.Equals("True"))
            {
                vegetarian = true;
            }
            else
            {
                vegetarian = false;
            }
        }
    }

    public Dish(string name, int price, string vegetarian)      //constructor
    {
        this.Name = name;
        this.Price = price;
        this.IsVegetarian = vegetarian;
    }
}