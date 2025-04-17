namespace W01
{
    class Exercise3
    {
        static void Main(string[] args)
        {

            Random number = new Random();
            int magicNumber = number.Next(1, 100);
            Console.WriteLine(magicNumber);
            // Console.WriteLine("What is the magic number?");
            // string userNumber = Console.ReadLine(); 
            // int MagicNumber = int.Parse(userNumber);
            int Guess;



            do
            {
                Console.WriteLine("What is your guess?");
                string input = Console.ReadLine();
                Guess = int.Parse(input);

                if (Guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (Guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

            } while (Guess != magicNumber);

            if (Guess == magicNumber)
            {
                Console.Write("Good Job");
            }


        }
    }

}
