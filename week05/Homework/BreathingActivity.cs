namespace week05
{
    class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description) : base(name, description) { }

        public void Run()
        {
            DisplayStartingMessage();
            ShowBeginCountDown(3);

            int runtime = _duration;
            while (runtime > 0)
            {
                // Break the questions up into 10 second blocks
                if (runtime > 10)
                {
                    Console.Write("Breathe in...");
                    ShowCountDown(4);

                    Console.Write("\nBreathe out...");
                    ShowCountDown(6);

                    runtime = runtime - 10;
                }

                // If the runtime is less than 10 seconds, break the remaining time up into 2/5 breathing in and 3/5 breathing out
                else
                {
                    Console.Write("Breathe in...");
                    ShowCountDown((int)Math.Round(runtime * (2.0 / 5)));

                    Console.Write("\nBreathe out...");
                    ShowCountDown((int)Math.Round(runtime * (3.0 / 5)));

                    runtime = 0;
                }

                Console.WriteLine("\n\n");
            }

            _totalDuration = _totalDuration + _duration;

            DisplayEndingMessage();
        }
    }
}