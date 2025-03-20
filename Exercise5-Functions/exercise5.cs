using System.Numerics;

namespace W01
{
    class Exercise5
    {
        public static void Functions()
        {
            DisplayWelcome();
            DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
        }

        private static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        private static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        private static int PromptUserNumber()
        {
            Console.Write("What is your fave number? ");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            return num;
        }

        private static int SquareNumber(int sqNum)
        {
            return sqNum*sqNum;
        }

        private static void DisplayResult(string name, int sqNum){
            Console.WriteLine($"{name}, the square of your number is {sqNum}");
        }
    }
}
