using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
    private ArrayList order = new ArrayList();
    public ArrayList Order
    {
        get { return order; }
        set
        {
            order = value;
        }
       
    }
    private int number;
    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
        }
    }
    
    private bool isOcupied;
    public bool IsOccupied
    {
        
        get 
        {
            return isOcupied;
        }
        set
        {
            isOcupied = value;
        }
    }

    public void AddToOrder(Dish name)
    {
        order.Add(name);
    }


    public void Ocupy
    {
        isOcupied = true;
    }

    public void Free;
    {
        isOcupied = false;
        order.Clear();
    }

   

    public Table(int number, bool isOcupied, ArrayList order)
    {
        this.Number = number;
        this.IsOccupied = isOcupied;
        this.Order = order;
    }

}