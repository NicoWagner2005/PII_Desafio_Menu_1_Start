namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    private ArrayList AddDish(string dishName)
    {
        dishes.add(dishName);
    }

    private ArrayList RemoveDish(string dishName)
    {
        dishes.RemoveAt(dishes.IndexOf(dishName));
    }

    private string GetDishByName(string dishName)
    {
        foreach (string dish in dishes)
        {
            if (dish == dishName)
            {
                return dish;
            }
            else
            {
                return null
            }
        }
    }
    
}