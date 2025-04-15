namespace week06
{
    class GoalManager
    {
        private List<Goal> _goals;
        private int _score;
        // This is a part of my creative work. I added a leveling and experience system
        private int _level;
        private int _experienceToNextLevel;

        public GoalManager(List<Goal> goals, int score)
        {
            _goals = goals;
            _score = score;
            _level = 1;
            SetExperienceAndLevel(_level + 1);
        }

        public int GetScore()
        {
            return _score;
        }

        public int GetLevel()
        {
            return _level;
        }

        // Further part of my leveling system. I used an existing formula from Runescape as my level scaling
        private void SetExperienceAndLevel(int level) {
            int points = 0;
            int output = 0;
            for (int lvl = 1; lvl <= level; lvl++) 
            {
                points += (int)Math.Floor(lvl + 300.0 * Math.Pow(2.0, lvl / 7.0));
                if (lvl >= level) {
                    break;
                }
                output = (int)Math.Floor(points / (double)4);
            }
            if (output < _score)
                SetExperienceAndLevel(level+1);
            else
            {
                _level = level-1;
                _experienceToNextLevel = output;
            }
        }

        public void Start()
        {
            int menuSelection = 0;
            int numMenuOptions = 6;

            while (menuSelection != numMenuOptions)
            {
                string menuString = $"\nYou have {_score} points.\n" +
                $"You are level {_level} with {_experienceToNextLevel - _score}xp (points) left to the next level\n\n" +
                "Menu Options:\n" +
                "  1. Create New Goal\n" +
                "  2. List Goals\n" +
                "  3. Save Goals\n"  +
                "  4. Load Goals\n" +
                "  5. Record Event\n" +
                "  6. Quit\n" +
                "Select a choice from the menu: ";

                Menu.DisplayMenuString(menuString);
                // there are 6 options, so pass in the numMenuOptions variable
                menuSelection = Menu.GetMenuSelection(numMenuOptions);

                switch (menuSelection)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoalDetails();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        // search through all of the files in the current directory and see if there are any .txt files
                        foreach(string file in Directory.EnumerateFiles(Directory.GetCurrentDirectory()))
                        {
                            string[] lines = File.ReadAllLines(file);

                            // if a txt file is found and there are the same number of more goals in it, 
                            // its assumed that the user has saved their goals already. Don't autosave.
                            if (file.Contains(".txt") && lines.Count()-1 >= _goals.Count)
                            {
                                Console.WriteLine("Thank you for recording your goals! I hope you saved them! :)");
                                return;
                            }
                        }
                        // if it gets here, that means a txt was not found in the current directory, or the 
                        // number of goals in the file is less than the current goals so trigger the autosave and let the user know
                        TempSaveGoals();
                        break;
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points.");
        }

        // public void ListGoalNames()
        // {
        //     foreach(Goal goal in _goals)
        //     {
        //         Console.WriteLine(goal.GetShortName());
        //     }
        // }

        public void ListGoalDetails()
        {
            Console.WriteLine("The goals are:\n");
            int index = 1;

            if (_goals.Count < 1)
            {
                Console.WriteLine("None :(");
                return;
            }

            foreach(Goal goal in _goals)
            {
                Console.WriteLine($"{index}. [{(goal.IsComplete() ? "X" : " ")}] {goal.GetDetailsString()}");
                index++;
            }
        }

        public void CreateGoal()
        {
            string menuString = "The type of Goals are:\n" +
                            "  1. Simple Goal\n" +
                            "  2. Eternal Goal\n"  +
                            "  3. Checklist Goal\n" +
                            "Which type of goal would you like to create? ";
            int numMenuOptions = 3;

            Menu.DisplayMenuString(menuString);
            int menuSelection = Menu.GetMenuSelection(numMenuOptions);

            string shortName = Menu.GetStringInput("What is the name of your goal? ");
            string description = Menu.GetStringInput("What is a short description of your goal? ");
            int points = Menu.GetIntInput("What is the amount of points associated with this goal? ");

            switch(menuSelection)
            {
                case 1:
                    SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);
                    _goals.Add(simpleGoal);
                    break;
                case 2:
                    EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case 3:
                    int target = Menu.GetIntInput("How many times does this goal need to be accomplished for a bonus? ");
                    int bonus = Menu.GetIntInput("What is the bonus for accomplishing it that many times? ");
                    ChecklistGoal checklistGoal = new ChecklistGoal(target, bonus, shortName, description, points);
                    _goals.Add(checklistGoal);
                    break;
                default:
                    break;
            }
        }

        public void RecordEvent()
        {
            if (_goals.Count < 1)
            {
                Console.WriteLine("Please try entering goals first before trying to complete them. That usually helps!");
                return;
            }
            string menuString = "";
            int index = 1;
            
            // put each goal into a string to pass to the Menu class
            foreach(Goal goal in _goals)
            {
                menuString += $"{index}. {goal.GetShortName()} -- {(goal.IsComplete() ? "Complete" : "Not Complete")}\n";
                index++;
            }

            Menu.DisplayMenuString(menuString);
            // we need to subtract 1 from the menu selection since it is a 0-indexed array
            int menuSelection = Menu.GetMenuSelection(_goals.Count) -1;

            if (!_goals[menuSelection].IsComplete())
            {
                _goals[menuSelection].RecordEvent();
                int earnedPoints = _goals[menuSelection].CalculateEarnedPoints();

                if (earnedPoints > 0)
                {
                    Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
                    _score += earnedPoints;
                    
                    if (_score > _experienceToNextLevel)
                    {
                        SetExperienceAndLevel(_level);
                        Console.WriteLine($"Congratulations! You leveled up! Your level is now {_level}!");
                    }
                }
            }
            else
                Console.WriteLine("Sorry, you cannot complete an already completed goal. Try creating another goal or making an Eternal goal instead!");
        }

        public void SaveGoals()
        {
            if (_goals.Count < 1)
            {
                Console.WriteLine("You have no goals to save. :( Please create some goals first and then attempt to save again.");
                return;
            }

            string fileName = Menu.GetStringInput("What file would you like to save the goals to? ");
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine($"{_score}`{_level}`{_experienceToNextLevel}");

                foreach(Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        }

        // This is part of my creative work. I added an auto-save feature that saves the goals if a save file of goals isn't found
        public void TempSaveGoals()
        {
            string fileName = "tempGoals.txt";
            string path = Directory.GetCurrentDirectory() + "\\" + fileName;
            using (StreamWriter outputFile = new StreamWriter(path))
            {
                outputFile.WriteLine($"{_score}`{_level}`{_experienceToNextLevel}");

                foreach(Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"We didn't find any .txt files with a matching number of goals, so we saved your goals to {path}.\n" +
                                $"Please load your goals from {fileName} the next time you run this program. Thank you!");
        }

        public void LoadGoals()
        {
            string fileName = Menu.GetStringInput("What file would you like to load the goals from? ");
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                int lineNumber = 1;

                foreach (string line in lines)
                {
                    if (lineNumber == 1)
                    {
                        string[] goalManagerAttributes = line.Split("`");
                        _score = int.Parse(goalManagerAttributes[0]);
                        _level = int.Parse(goalManagerAttributes[1]);
                        _experienceToNextLevel = int.Parse(goalManagerAttributes[2]);
                    }
                    else
                    {
                        string[] strings = line.Split("=");
                        string[] attributes = strings[1].Split("`");

                        switch (strings[0])
                        {
                            case "SimpleGoal":
                                _goals.Add(new SimpleGoal(attributes[0], attributes[1], int.Parse(attributes[2]), attributes[3]=="True"));
                                break;
                            case "EternalGoal":
                                _goals.Add(new EternalGoal(attributes[0], attributes[1], int.Parse(attributes[2])));
                                break;
                            case "ChecklistGoal":
                                _goals.Add(new ChecklistGoal(int.Parse(attributes[0]), int.Parse(attributes[1]), attributes[2], attributes[3], int.Parse(attributes[4])));
                                break;
                            default:
                                break;
                        }
                    }

                    lineNumber++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid filename. If the file exists, please check the spelling and be sure to include the extension.");
            }
        }
    }
}