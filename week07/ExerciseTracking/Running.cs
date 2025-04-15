namespace week07
{
    class Running: Activity
    {
        private double _distance;

        public Running(double distance, DateOnly date, double minutes): base(date, minutes)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            double returnValue = _distance / 60.0;
            return returnValue;
        }

        public override double GetPace()
        {
            double returnValue = 60.0 / GetSpeed();
            return returnValue;
        }
    }
}