namespace week05
{
    class ListingActivity: Activity
    {
        public int _count { get; set; }
        public List<string> _prompts { get; set; }

        public ListingActivity(int count, string name, string description): base(name, description)
        {
            _count = count;
            _prompts = ReadListFromFile("listingPrompts.txt");
        }

        private List<string> ReadListFromFile(string fileName)
        {
            string text = File.ReadAllText($"{Directory.GetCurrentDirectory()}\\{fileName}");
            return new List<string>(text.Split(","));
        }


        public void Run()
        {
            DisplayStartingMessage();
            ShowBeginCountDown(3);

            Console.WriteLine($"List as many responses as you can to the following prompt:\n --- {GetRandomPrompt()} ---");

            List<string> responses = GetListFromUser();

            Console.Write($"You listed {responses.Count} items!\n\n");

            _totalDuration = _totalDuration + _duration;

            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }

        // What the heck is this supposed to do?
        public List<string> GetListFromUser()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            List<string> responses = [];

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                responses.Add(Console.ReadLine());
            }
            return responses;
        }
    }
}