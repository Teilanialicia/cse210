namespace week07
{
    class Cycling: Activity
    {
        private double _speed;

        public Cycling(double speed, DateOnly date, double minutes): base(date, minutes)
        {
            _speed = speed;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetDistance()
        {
            double returnValue = _speed * GetMinutes();
            return returnValue;
        }

        public override double GetPace()
        {
            double returnValue = 60.0 / _speed;
            return returnValue;
        }
    }
}