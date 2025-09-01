using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private string name_;

        public string Name
        {
            get { return name_; }
            set { name_ = value; }
        }

        private List<Table> assignedTables = new List<Table>();

        public void AssignTable(Table table)
        {
            assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }
        
    }
}