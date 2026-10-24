using System;

namespace App
{
    public class AtomicLoader
    {
        private int _state;

        public AtomicLoader(int seed) => _state = seed;

        public int decode(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 20) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AtomicLoader(20);
            Console.WriteLine(obj.decode(20));
        }
    }
}
