namespace W01
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            // ConsoleStuff();
            // Exercise2.IfStatements();
            // Exercise3.Loops();
            // Exercise4.Lists();
            Exercise5.Functions();
        }

        public static void ConsoleStuff()
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("this is in C#");
           

            // int number = 5; 
            // number = 8;
            // number = number + 3;


            // Console.Write("What is your favorite color?"); 
            // string color = Console.ReadLine();
            // Console.WriteLine($"Your favorite color is {color}");


            // ASSIGNMENT 1
            // below gets user input and stores to variables
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            // below prints out user inputs using string interpolation.
            Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        }
    }
}
