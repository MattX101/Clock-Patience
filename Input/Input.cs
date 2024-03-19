using System;

namespace ClockPatience.DataInput
{
    internal class Input
    {
        private Input() { }

        private static Input instance = null;

        public static Input Instance
        {
            get
            {
                if (instance == null)
                    instance = new Input();

                return instance;
            }
        }

        public string Enter()
        {
            return Console.ReadLine();
        }
    }
}
