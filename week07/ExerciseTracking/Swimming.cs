namespace week07
{
    class Swimming: Activity
    {
        private int _laps;

        public Swimming(int laps, DateOnly date, double minutes): base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            double returnValue = _laps * 50.0 / 1000.0;
            return returnValue;
        }

        public override double GetSpeed()
        {
            double returnValue = GetDistance() / 60.0;
            return returnValue;
        }

        public override double GetPace()
        {
            double returnValue = 60.0 / GetSpeed();
            return returnValue;
        }
    }
}