using System;

namespace App
{
    public class SimpleRegistry
    {
        private int _state;

        public SimpleRegistry(int seed) => _state = seed;

        public int render(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 30) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SimpleRegistry(30);
            Console.WriteLine(obj.render(30));
        }
    }
}
