namespace W02
{
    class Project
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool continueLoop;
            
            do
            {
                Menu();
                continueLoop = MenuInput(journal);
            } while(continueLoop);
        }

        // Provide a menu 
        public static void Menu()
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
        }

        // Get the user's input on what menu item they want to select
        public static bool MenuInput(Journal journal){
            Console.WriteLine("What would you like to do? ");
            string answer = Console.ReadLine();

            if (answer == "1"){
                journal.Write();
            }
            else if (answer =="2"){
                journal.Display();
            }
            else if (answer =="3"){
                journal.Load();
            }
            else if (answer =="4"){
                journal.Save();
            }
            else if (answer =="5"){
                // The user wants to quit - Break out of the loop
                return false;
            }
            
            return true;
        }


    }


}
