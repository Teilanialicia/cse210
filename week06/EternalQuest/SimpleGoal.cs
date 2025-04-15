namespace week06
{
    class SimpleGoal: Goal
    {
        private bool _isComplete;

        public SimpleGoal(string shortName, string description, int points, bool isComplete=false): base(shortName, description, points)
        {
            _isComplete = isComplete;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override int CalculateEarnedPoints()
        {
            if (IsComplete())
                return base.CalculateEarnedPoints();
            else
                return 0;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            string attributeDeliniator = "`";
            return $"SimpleGoal={GetShortName()}{attributeDeliniator}{GetDescription()}{attributeDeliniator}{GetPoints()}{attributeDeliniator}{_isComplete}";
        }
    }
}