namespace W02
{

    class Prompt
    {
        static List<string> _prompts = [
            "What are three things I am grateful for today, and why?",
            "Describe a time when I overcame a difficult situation. How did I manage my anxiety?",
            "What is one small step I can take today to reduce my stress?",
            "Write about a place (real or imagined) where I feel completely at peace.",
            "What positive affirmations can I tell myself when I feel anxious?",
            "List five things that bring me joy and explain why they are meaningful to me.",
            "What is something I accomplished recently that I am proud of?",
            "How can I be kinder to myself when I experience anxious thoughts?",
            "Write a letter to my future self, offering encouragement and support.",
            "What are three activities that help me relax and feel more positive?"
        ];



        public static string GetRandomPrompt()
        {
            // Random object
            Random prompts = new Random();

            // Get random index
            int number = prompts.Next(_prompts.Count);

            // Print random prompt
            return _prompts[number];
        }
    }

}