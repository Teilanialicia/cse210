namespace week04
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Kelly", "546 Sandy Way", "Port Rowan", "Ontario", "Canada");
            Customer customer2 = new Customer("Viktor", "645 Breezy Way", "Star Trek", "San Francisco", "USA");

            List<Product> list1 = [
                new Product("Notebook", 101, 2.99, 50),
                new Product("Pen", 102, 0.99, 200),
                new Product("Backpack", 103, 29.99, 30)
            ];

            List<Product> list2 = [
                new Product("Water Bottle", 104, 9.49, 75),
                new Product("Calculator", 105, 14.99, 40),
                new Product("Binder", 106, 5.99, 60)
            ];

            Order order1 = new Order(list1, customer1);
            Order order2 = new Order(list2, customer2);

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine(order1.getTotalPrice());

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine(order2.getTotalPrice());
        }
    }
}