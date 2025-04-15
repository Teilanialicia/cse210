namespace week07
{
    class Activity
    {
        private DateOnly _date;
        private double _minutes;

        public Activity(DateOnly date, double minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public DateOnly GetDate()
        {
            return _date;
        }

        public string GetInheritedType()
        {
            string removeString = "week07.";
            string sourceString = this.GetType().ToString();
            int index = sourceString.IndexOf(removeString);
            return sourceString.Remove(index, removeString.Length);
        }

        public double GetMinutes()
        {
            return _minutes;
        }

        virtual public double GetDistance()
        {
            return 0;
        }

        virtual public double GetSpeed()
        {
            return 0;
        }

        virtual public double GetPace()
        {
            return 0;
        }
    }
}