using System.Reflection.Metadata;
using System.Text.Json;

namespace week05
{
    class ReflectingActivity: Activity
    {
        public List<string> _prompts { get; set; }
        public List<string> _questions { get; set; }

        public ReflectingActivity(string name, string description): base(name, description)
        {
            _prompts = ReadListFromFile("reflectingPrompts.txt");
            _questions = ReadListFromFile("reflectingQuestions.txt");
        }

        // This is part of showing my creativity - I created this method to read in all of the lists from another file so the prompts and questions can easily be updated
        private List<string> ReadListFromFile(string fileName)
        {
            string text = File.ReadAllText($"{Directory.GetCurrentDirectory()}\\{fileName}");
            return new List<string>(text.Split(","));
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine($"Consider the following prompt:\n\n --- {GetRandomPrompt()} ---\n\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();
            ShowBeginCountDown(3);
            DisplayQuestions();
            _totalDuration = _totalDuration + _duration;
            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            Random random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }

        private string GetRandomQuestion()
        {
            Random random = new Random();
            return _questions[random.Next(_questions.Count)]; 
        }

        public void DisplayPrompt()
        {
            Console.WriteLine(GetRandomPrompt());
        }

        public void DisplayQuestions()
        {
            Console.Clear();

            int runtime = _duration;
            // The time that a question is shown in seconds
            int questionDuration = 10;

            // If the runtime is less than the defined 10 seconds for the questions, just make the question only last for runtime amount of seconds
            if (runtime < 10)
            {
                questionDuration = runtime;
            }

            while (runtime > 0)
            {
                Console.Write(GetRandomQuestion());
                ShowSpinner(questionDuration);

                runtime = runtime - questionDuration;
                Console.WriteLine("\n\n");
            }
        }
    }
}