namespace week06
{
    class EternalGoal: Goal
    {
        
        public EternalGoal(string shortName, string description, int points): base(shortName, description, points)
        {

        }

        public override void RecordEvent()
        {
            return;
        }

        public override int CalculateEarnedPoints()
        {
            return base.CalculateEarnedPoints();
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetStringRepresentation()
        {
            string attributeDeliniator = "`";
            return $"EternalGoal={GetShortName()}{attributeDeliniator}{GetDescription()}{attributeDeliniator}{GetPoints()}";
        }
    }
}