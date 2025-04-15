namespace week06
{
    static class Menu
    {
        public static void DisplayMenuString(string menuString)
        {
            // Console.Clear();
            Console.Write(menuString);
        }

        public static int GetMenuSelection(int maxMenuSelection)
        {
            int menuSelection = 0;

            while (menuSelection < 1 || menuSelection > maxMenuSelection)
            {
                try
                {
                    menuSelection = int.Parse(Console.ReadLine());

                    if (menuSelection > maxMenuSelection || menuSelection < 1)
                        throw new Exception();

                    // add a newline for better readability
                    Console.WriteLine();
                }
                catch(Exception)
                {
                    Console.WriteLine($"Please enter a valid menu selection (1-{maxMenuSelection})");
                }
            }
            return menuSelection;
        }

        public static string GetStringInput(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetIntInput(string question)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(question);
                    int intInput = int.Parse(Console.ReadLine());
                    return intInput;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid integer value.\n");
                }
            }
            
        }
    }
}