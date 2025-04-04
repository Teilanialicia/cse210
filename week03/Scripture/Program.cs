using System.Text.Json;

namespace week03
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is my exceeding expectations. I read the scripture from a file and turned it into the scripture object. this works for any scripture if you follow the example!
            string contents = File.ReadAllText($"{Directory.GetCurrentDirectory()}\\scripture.txt");
            string[] splitData = contents.Split("`");
            string[] referenceData = splitData[0].Split(",");
            string textData = splitData[1];
            Reference reference;

            if (referenceData.Length > 3)
            {
                reference = new Reference(referenceData[0], int.Parse(referenceData[1]), int.Parse(referenceData[2]), int.Parse(referenceData[3]));
            }
            else
            {
                reference = new Reference(referenceData[0], int.Parse(referenceData[1]), int.Parse(referenceData[2]));
            }

            Scripture scripture = new Scripture(reference, textData);

            Console.WriteLine("How many words would you like hidden per round? ");
            int numberToHide = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
                string input =  Console.ReadLine();

                if (input == "quit" || scripture.IsCompletelyHidden())
                    break;

                scripture.HideRandomWords(numberToHide);
                Console.Clear();
            }
        }
    }
}