namespace W01
{
    class Exercise1
    {
        static void Main(string[] args)
        {
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
