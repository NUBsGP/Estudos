﻿using System;
using System.Globalization;

namespace Aula233.Entities
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
