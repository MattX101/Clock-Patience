using System.Collections.Generic;

namespace ClockPatience.Data
{
    internal static class PileMapping
    {
        public static readonly Dictionary<char, int> Map = new Dictionary<char, int>()
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
