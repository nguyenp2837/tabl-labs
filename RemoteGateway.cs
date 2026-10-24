using System;

namespace App
{
    public class AsyncResolver
    {
        private int _state;

        public AsyncResolver(int seed) => _state = seed;

        public int run(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 45) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AsyncResolver(45);
            Console.WriteLine(obj.run(45));
        }
    }
}
