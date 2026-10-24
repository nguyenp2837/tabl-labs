using System;

namespace App
{
    public class CoreResolver
    {
        private int _state;

        public CoreResolver(int seed) => _state = seed;

        public int sync(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 84) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new CoreResolver(84);
            Console.WriteLine(obj.sync(84));
        }
    }
}
