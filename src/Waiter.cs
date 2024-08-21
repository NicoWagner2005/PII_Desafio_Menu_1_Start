using System.Collections;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private ArrayList assignedTables = new ArrayList();
    public ArrayList AssignedTables
    {
        get {return assignedTables;}
        set { assignedTables.Add(value);
    }
}

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }


//Constructor??????!?!?!/!!?!?!?!?!?!?!!!?!!?!?!?
    public Waiter(string name, ArrayList assignedTables)
    {
        this.Name = name;
        this.AssignedTables = assignedTables;
    }

    public void AssignTables(Table);
    {
        assignedTables.Add(Table);
    }

    public void TakeOrder(Table, Dish)
    {
        Table.AddToOrder(Dish);
    }


























}