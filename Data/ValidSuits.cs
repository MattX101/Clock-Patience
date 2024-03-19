namespace ClockPatience.Data
{
    internal class ValidSuits
    {
        private ValidSuits() { }

        private static ValidSuits instance = null;

        public static ValidSuits Instance
        {
            get
            {
                if (instance == null)
                    instance = new ValidSuits();

                return instance;
            }
        }

        public readonly char[] Suits = new char[]
        {
            'H', 'D', 'C', 'S'
        };
    }
}
