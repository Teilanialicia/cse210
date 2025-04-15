namespace week07
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Activity> activities = [];
            activities.Add(new Swimming(3,DateOnly.FromDateTime(DateTime.Now),30));
            activities.Add(new Running(5, DateOnly.FromDateTime(DateTime.Now), 20));
            activities.Add(new Cycling(15, DateOnly.FromDateTime(DateTime.Now), 30));

            foreach (Activity activity in activities)
            {
                Console.WriteLine($"{activity.GetDate()} {activity.GetInheritedType()} ({activity.GetMinutes()} minutes) -" +
                $" Distance {activity.GetDistance()} kilometers, Speed {activity.GetSpeed()} km/h, Pace: {activity.GetPace()} min/km");
            }
        }
    }
}