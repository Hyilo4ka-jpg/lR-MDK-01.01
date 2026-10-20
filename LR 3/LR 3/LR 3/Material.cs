using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    public enum MaterialType
    {
        Cement = 1,
        Brick = 2,
        CorrugatedSheet = 3,
        Drywall = 4,
        Nails = 5
    }

    public class Material
    {
        public MaterialType Type;
        public string Name;
        public int Price;
        public int Quantity;

        public Material(
            MaterialType type,
            string name,
            int price,
            int quantity)
        {
            Type = type;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void RemoveQuantity(int quantity)
        {
            Quantity -= quantity;
        }
    }
}

