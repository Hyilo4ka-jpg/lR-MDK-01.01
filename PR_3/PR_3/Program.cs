using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product();
            product1.SetName("Клей Момент");
            product1.SetPrice(350);
            product1.SetQuantity(200);
            products.Add(product1);
        }
    }
}
