using System.Reflection.Metadata.Ecma335;

namespace week05
{
    class Activity
    {
        public string _name { get; set; }
        public string _description { get; set; }
        public int _duration { get; set; }

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
            _duration = 0;
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name} Activity\n\n{_description}\n\nHow long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine($"Well done!!");
            ShowSpinner(3);
            Console.WriteLine($"\n\nYou have completed another {_duration} seconds of the {_name} Activity");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            List<string> animation = ["-", "\\", "|", "/"];

            // Speed in milliseconds
            int animationSpeed = 250;

            // Convert the seconds to milliseconds
            int milliseconds = seconds * 1000;

            // Keep track of the animation index
            int animationIndex = 0;

            while (milliseconds > 0)
            {
                Console.Write(animation[animationIndex]);
                animationIndex++;

                if (animationIndex >= animation.Count)
                    animationIndex = 0;

                milliseconds = milliseconds - animationSpeed;

                Thread.Sleep(animationSpeed);
                Console.Write("\b \b");
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public void ShowBeginCountDown(int seconds)
        {
            Console.Write("You may begin in: ");
            ShowCountDown(seconds);
            Console.WriteLine("\n\n");
        }

    }
}