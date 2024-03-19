using System.Collections.Generic;

namespace ClockPatience.Data
{
    internal class PileMapping
    {
        private PileMapping() { }

        private static PileMapping instance = null;

        public static PileMapping Instance
        {
            get
            {
                if (instance == null)
                    instance = new PileMapping();

                return instance;
            }
        }

        /// <summary>
        /// Used to convert a card Rank into a number
        /// </summary>
        public readonly Dictionary<char, int> Map = new Dictionary<char, int>()
        {
            {'A', 0},
            {'2', 1},
            {'3', 2},
            {'4', 3},
            {'5', 4},
            {'6', 5},
            {'7', 6},
            {'8', 7},
            {'9', 8},
            {'T', 9},
            {'J', 10},
            {'Q', 11},
            {'K', 12}
        };
    }
}
