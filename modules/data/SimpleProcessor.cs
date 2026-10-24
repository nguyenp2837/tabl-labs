using System;

namespace App
{
    public class SimpleGateway
    {
        private int _state;

        public SimpleGateway(int seed) => _state = seed;

        public int compute(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 38) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SimpleGateway(38);
            Console.WriteLine(obj.compute(38));
        }
    }
}
