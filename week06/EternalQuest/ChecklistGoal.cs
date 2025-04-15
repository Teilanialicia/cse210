namespace week06
{
    class ChecklistGoal: Goal
    {
        
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(int target, int bonus, string shortName, string description, int points, int amountCompleted=0): base(shortName, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            if (!IsComplete())
                _amountCompleted++;
        }

        public override int CalculateEarnedPoints()
        {
            if (IsComplete())
                return GetPoints() + _bonus;
            else
                return GetPoints();
        }

        public override bool IsComplete()
        {
            return _target == _amountCompleted;
        }

        public override string GetDetailsString()
        {
            return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            string attributeDeliniator = "`";
            return $"ChecklistGoal={_target}{attributeDeliniator}{_bonus}{attributeDeliniator}" +
                    $"{GetShortName()}{attributeDeliniator}{GetDescription()}{attributeDeliniator}{GetPoints()}{attributeDeliniator}{_amountCompleted}";
        }
    }
}