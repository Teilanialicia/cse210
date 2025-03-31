using System.ComponentModel.Design;

namespace W01
{
    public class Exercise4
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            int intInput = 5;
            List<int> list = [];

            while (intInput != 0)
            {
                Console.Write("Enter number: ");
                var input = Console.ReadLine();
                intInput = int.Parse(input);

                if (intInput != 0)
                {
                    list.Add(intInput);
                }

            }

            int sum = 0;

            foreach (int listItem in list)
            {
                sum += listItem;
            }
            Console.WriteLine($"The sum is: {sum}");

            double average = (double)sum / list.Count;
            Console.WriteLine($"The average is: {average}");

            int big = list.Max();
            Console.WriteLine($"The largest number is: {big}");
        }


        public void Listss()
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            names.Sort();

            // List<int> x = [1,2,3,4,5];

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }

    // public class Person
    // {
    //     public string firstName;
    //     public string lastname;

    // }
}

