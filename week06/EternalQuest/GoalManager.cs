public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    Dictionary<string, string> userLevels = new Dictionary<string, string>
    {
        { "Level 1", "★" },
        { "Level 2", "★★" },
        { "Level 3", "★★★" },
        { "Level 4","★★★★" },
        { "Level 5", "★★★★★" }
    };

    public void GetLevel()
    {
        Console.Write("Congrats! You are ");
        if (_score > 0 && _score <= 50)
        {
            Console.WriteLine($"Level 1: {userLevels["Level 1"]}");
        }
        else if (_score > 50 && _score <= 200)
        {
            Console.Write($"Level 2: {userLevels["Level 2"]}");
        }
        else if (_score > 200 && _score <= 400)
        {
            Console.WriteLine($"Level 3: {userLevels["Level 3"]}");
        }
        else if (_score > 400 && _score <= 600)
        {
            Console.WriteLine($"Level 4: {userLevels["Level 4"]}");
        }
        else if (_score > 600)
        {
            Console.WriteLine($"Max Level Reached! \nLevel 5: {userLevels["Level 5"]}");
        }
    }

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";
        Console.Clear();

        while (choice != "6")
        {
            Console.WriteLine($"\nYou have {_score} points.");
            GetLevel();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("Whoops! Looks like you have no goals. Time to make some!");
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.Write("\nInvalid choice. Please try again.");
            Console.WriteLine("\nTypes of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            choice = Console.ReadLine();
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("Whoops! Looks like you have no goals to record.");
        }
        else
        {
            ListGoalNames();
            Console.Write("Which goal did you accomplish? ");
            int choice = int.Parse(Console.ReadLine()) - 1;

            Goal selectedGoal = _goals[choice];
            int earnedPoints = selectedGoal.RecordEvent();

            _score += earnedPoints;
            Console.WriteLine($"You have earned {earnedPoints} points!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the name of the file to save your goals: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Your goals have been saved to {fileName}");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the name of the file to load your goals from: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine($"We're sorry, the file {fileName} does not exist.");
        }
        else
        {
            string[] lines = File.ReadAllLines(fileName);
            _goals.Clear();
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string goalType = parts[0];
                string[] goalDetails = parts[1].Split(",");

                if (goalType == "Simple")
                {
                    string name = goalDetails[0];
                    string description = goalDetails[1];
                    string points = goalDetails[2];
                    bool isComplete = bool.Parse(goalDetails[3]);

                    SimpleGoal newGoal = new SimpleGoal(name, description, points, isComplete);

                    _goals.Add(newGoal);
                }
                else if (goalType == "Eternal")
                {
                    string name = goalDetails[0];
                    string description = goalDetails[1];
                    string points = goalDetails[2];
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (goalType == "Checklist")
                {
                    string name = goalDetails[0];
                    string description = goalDetails[1];
                    string points = goalDetails[2];

                    int amountCompleted = int.Parse(goalDetails[3]);
                    int target = int.Parse(goalDetails[4]);
                    int bonus = int.Parse(goalDetails[5]);

                    ChecklistGoal newGoal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);

                    _goals.Add(newGoal);
                }
            }
        }

    }
}