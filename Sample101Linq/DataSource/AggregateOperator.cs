namespace Sample101Linq.DataSource;

public class AggregateOperator
{
    public int CountSyntax()
    {
        #region count-syntax
        int[] factorsOf300 = { 2, 2, 3, 5, 5, 6, 6, 6 };

        int uniqueFactors = factorsOf300.Distinct().Count();

        Console.WriteLine($"There are {uniqueFactors} unique factors of 300.");
        #endregion
        return 0;
    }   
    
    public int CountConditional()
    {
        #region count-conditional
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        int oddNumbers = numbers.Count(n => n % 2 == 1);

        Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        #endregion
        return 0;
    }

    public int CountNested()
    {
        #region nested-count
        List<Customer> customers = Customers.GetCustomerList();

        /*
        var orderCounts = from c in customers
            select  (c.CustomerID,c.CompanyName, OrderCount: c.Orders.Count());

        foreach(var customer in orderCounts)
        {
            Console.WriteLine($"ID: {customer.CustomerID}, Name: {customer.CompanyName}, count: {customer.OrderCount}");
        }
        */
        
        var orderCounts = from c in customers
            where c.City.Equals("Berlin")
            select new
            {
                ID = c.CustomerID,
                Name = c.CompanyName,
                Count = c.Orders.Count()
            };

        foreach(var customer in orderCounts)
        {
            Console.WriteLine($"ID: {customer.ID}, Name: {customer.Name}, count: {customer.Count}");
        }

        #endregion
        return 0;
    }
}