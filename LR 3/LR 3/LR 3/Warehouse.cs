using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{

    public class Warehouse
    {
        public List<Material> materials;

        public Warehouse()
        {
            materials = new List<Material>
        {
            new Material(MaterialType.Cement, "цемент", 650, 30),
            new Material(MaterialType.Brick, "кирпич", 250, 40),
            new Material(MaterialType.CorrugatedSheet, "профнастил", 1450, 20),
            new Material(MaterialType.Drywall, "гипсокартон", 420, 25),
            new Material(MaterialType.Nails, "гвозди", 90, 35)
        };
        }

        public void PrintMaterials()
        {
            Console.WriteLine("Склад стройматериалов:");
            Console.WriteLine();

            foreach (Material material in materials)
            {
                Console.WriteLine(
                    $"{(int)material.Type}. {material.Name} — " +
                    $"{material.Price} руб., {material.Quantity} шт.");
            }

            Console.WriteLine();
        }

        public Material GetMaterial(MaterialType type)
        {
            foreach (Material material in materials)
            {
                if (material.Type == type)
                {
                    return material;
                }
            }

            return null;
        }

        public void PrintRemains()
        {
            Console.WriteLine();
            Console.Write("Остатки на складе: ");

            for (int i = 0; i < materials.Count; i++)
            {
                Console.Write(
                    $"{materials[i].Name} {materials[i].Quantity}");

                if (i < materials.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }

}
