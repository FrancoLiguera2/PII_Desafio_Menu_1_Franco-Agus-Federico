using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
            private string name_;

            public string Name
            {
                get { return name_; }
                set { name_ = value; }
            }

            private double price_;

            public double Price
            {
                get { return price_; }
                set { price_ = value; }
            }

            private bool _isVegetarian;

            public bool IsVegetarian
            {
                get { return _isVegetarian;}
                set { _isVegetarian = value; }
            }
        }
    }
