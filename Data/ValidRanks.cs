namespace ClockPatience.Data
{
    internal class ValidRanks
    {
        private ValidRanks() { }

        private static ValidRanks instance = null;

        public static ValidRanks Instance
        {
            get
            {
                if (instance == null)
                    instance = new ValidRanks();

                return instance;
            }
        }

        public readonly char[] Ranks = new char[]
        {
            'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K'
        };
    }
}
