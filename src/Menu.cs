using System.Net.Http.Headers;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();
    public ArrayList Dishes
    {
        get
        {
            return dishes;
        }
        set
        {
            dishes.Add(value);
        }
    }

    public void AddDish(Dish name)
    {
        dishes.Add(name);
    }

    public void RemoveDish(Dish name)
    {
        dishes.RemoveAt(dishes.IndexOf(name));
        
    }

    private string GetDishByName(Dish name)
    {
        foreach (string dish in dishes)
        {
            if (dish.Equals(name))
            {
                return dish;
            }
            else
            {
                return null;
            }
        }
    }
}