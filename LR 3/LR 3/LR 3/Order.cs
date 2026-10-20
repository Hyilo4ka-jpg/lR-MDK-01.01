using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{

    public class Order
    {
        public Dictionary<MaterialType, int> Items;

        public Order()
        {
            Items = new Dictionary<MaterialType, int>();
        }

        public void AddItem(MaterialType type, int quantity)
        {
            if (Items.ContainsKey(type))
            {
                Items[type] += quantity;
            }
            else
            {
                Items[type] = quantity;
            }
        }

        public int CalculateCost(Warehouse warehouse)
        {
            int totalCost = 0;

            foreach (var item in Items)
            {
                Material material = warehouse.GetMaterial(item.Key);

                if (material != null)
                {
                    totalCost += material.Price * item.Value;
                }
            }

            return totalCost;
        }
    }

}
