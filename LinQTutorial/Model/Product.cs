using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Product(String name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    // toString
    public override string ToString()
    {
        return "Product { Name: " + this.Name + ", Price: Rp. " + this.Price + "}";
    }

    public static List<Product> GetData()
    {
        List<Product> products = new List<Product>()
        {
            new Product("Mie Goreng", 20000),
            new Product("Mie Ayam", 25000),
            new Product("Donat Mady", 30000),
        };

        return products;
    }

    public static void SampleFilterProduct()
    {
        // 1. create data source
        List<Product> products = GetData();

        // 2. create query
        IEnumerable<Product> productFilter = from item in products
                                             where item.Price >= 30000
                                             select item;

        // 3. execute query
        foreach (var product in productFilter)
        {
            Console.WriteLine(product);
        }
    }

    public static void SampleFilterByName()
    {
        // 1. create data source
        List<Product> products = GetData();

        // 2. create query
        IEnumerable<Product> productFilter = from product in products
                                             where product.Name.Contains("Mie")
                                             select product;

        // 3. execute query
        foreach (var product in productFilter)
        {
            Console.WriteLine(product);
        }
    }
}
