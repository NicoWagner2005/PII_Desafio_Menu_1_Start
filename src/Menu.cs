namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    private ArrayList AddDish(string dish)
    {
        dishes.add(dish);
    }

    private ArrayList RemoveDish(string dish)
    {
        dishes.RemoveAt(dishes.IndexOf(dish));
    }

    private Dish GetDishByName(string dish)
    {
        if (dish in dishes)
        {
            return dishes[dishes.IndexOf(dish)];
        }
        else
        {
            return null
        }
    }

    public Menu(ArrayList dishes)
    {
        this.Dishes = dishes;
    }
    
    
}