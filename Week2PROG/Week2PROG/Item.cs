using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2PROG
{
    public class Item
    {

        public string Name;
        public double Value;
        public double Amount;
        public double Power;



        //public float Cost = 1.0f;
        //public decimal Price = 1.0m;
      

        

        public Item(string name, double value, double power)
        {
            Name = name;
            Value = value;
            Power = power;
        }

        public Item()
        {

        }

        public string DescriptionOfItems()
        {
            return $"{Amount} of {Name} and {Value}";
        }

       

    }
}