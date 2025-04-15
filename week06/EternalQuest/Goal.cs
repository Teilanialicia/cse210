namespace week06
{
    class Goal
    {
        private string _shortName;
        private string _description;
        private int _points;

        public Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }

        public string GetShortName()
        {
            return _shortName;
        }

        public string GetDescription()
        {
            return _description;
        }

        public int GetPoints()
        {
            return _points;
        }

        virtual public void RecordEvent()
        {
            return;
        }

        virtual public int CalculateEarnedPoints()
        {
            return _points;
        }

        virtual public bool IsComplete()
        {
            return false;
        }

        virtual public string GetDetailsString()
        {
            return $"{_shortName} ({_description})";
        }

        virtual public string GetStringRepresentation()
        {
            return "";
        }
    }
}