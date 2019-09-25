﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private double price;
        private int quantity;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price
        {
            get { return quantity; }
            set { price = value; }
        }
    }
}
