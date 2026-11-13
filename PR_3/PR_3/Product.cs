using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_3
{
    public class Product
    {
        protected string Name_ = "";
        protected double Price_;
        protected int Quantity_;

        public virtual double GetDiscount()
        {
            return 0;


        }

        public string GetName()
        {
            return Name_;
        }

        public void SetName(string name)
        {
            Name_ = name;
        }

        public double GetPrice()

        {
            return Price_;
        }

        public void SetPrice(double price)
        {
            Price_ = price;
        }

        public int GetQuantity()
        {
            return Quantity_;
        }

        public void SetQuantity(int quantity)
        {
            Quantity_ = quantity;
        }
    }
}
