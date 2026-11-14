using PR_3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PR_3
{
    public class CSVLoader
    {
        public static List<Product> LoadProducts(string filePath)
        {
            List<Product> products = new List<Product>();

            using(StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');

                    string name = parts[0].Trim();
                    double price = double.Parse(parts[1].Trim(),

                     CultureInfo.InvariantCulture
                    
                    );

                    int quantity = int.Parse(parts[2].Trim());
                    string type = parts[3].Trim();

                    Product product;

                    if (type == "Chancellery")
                    {
                        product = new Chancellery();
                    }
                    else if (type == "Artist")
                    {
                        product = new Artist();
                    }
                    else
                    {
                        product = new Product();
                    }

                    product.SetName(name);
                    product.SetPrice(price);
                    product.SetQuantity(quantity);

                    products.Add(product);
                }

            }

            return products;
        }
    }
}
