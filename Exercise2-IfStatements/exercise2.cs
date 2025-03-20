using System;

namespace W01
{
    class Exercise2
    {

        public static void IfStatements()
        {
            Console.Write("Enter numer: ");
            string valueFromUser = Console.ReadLine();

            int x = 5;
            int y = 2;
            int z = 5;

            if (x > y){  
                Console.WriteLine("Greater");
            } else if (x > y)
            {
                Console.WriteLine("Less");
            } else {
                Console.WriteLine("Equal");
            }

            Console.Write("What is your grade percentage? (numbers only)");
            string gradeInput = Console.ReadLine();

            int input = int.Parse(gradeInput);
            string letter = "";

            if (input >= 90){
                letter = "A";
            } 
            else if (input >= 80){
                letter = "B";
            } 
            else if (input >= 70){
                letter = "C";
            } 
            else if (input >= 60){
                letter = "D";
            } 
            else if (input < 60){
                letter = "F";
            } 
            else {
                Console.WriteLine("Invalid input.");
            }

            if (input >= 70){
                Console.WriteLine("Congratulations you passed the class!");
            }
            else {
                Console.WriteLine("It happens. Better luck next time!");
            }

            Console.WriteLine(letter);
        }
    }
}