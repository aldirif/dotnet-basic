using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Model;

public class Category
{
    public String CategoryName { get; set; }
    public int Count { get; set; }

    public Category(String name, int count)
    {
        this.CategoryName = name;
        this.Count = count;
    }

    public override string ToString()
    {
        return "Category { CategoryName: " + this.CategoryName + ", Count: " + this.Count + "}";
    }

    public static List<Category> GetData()
    {
        List<Category> categories = new List<Category>()
        {
            new Category("Makanan", 50),
            new Category("Snack", 100),
            new Category("Minuman", 150),

        };

        return categories;
    }

    public static void SampleFilterCategory()
    {
        List<Category> categories = GetData();

        IEnumerable<Category> categoryFilter = from item in categories
                                               where item.Count >= 100
                                               select item;
        foreach (var category in categoryFilter)
        {
            Console.WriteLine(category);
        }
    }
}