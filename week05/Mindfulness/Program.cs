namespace week05
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuSelection = 0;

            while (menuSelection != 4)
            {
                DisplayMenu();
                menuSelection = GetMenuSelection();

                if (menuSelection == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.Run();
                }
                else if (menuSelection == 2)
                {
                    ReflectingActivity reflectingActivity =  new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.Run();
                }
                else if (menuSelection == 3)
                {
                    ListingActivity listingActivity = new ListingActivity(5, "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.Run();
                }
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
        }

        static int GetMenuSelection()
        {
            try
            {
                int menuSelection = int.Parse(Console.ReadLine());

                if (menuSelection > 4 || menuSelection < 1)
                    throw new Exception();
                
                return menuSelection;
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter a valid menu selection (1-4)");
                // Sleep for 3 seconds so the user sees the error before it is cleared by DisplayMenu
                Thread.Sleep(2000);
                return 0;
            }
        }
    }
}