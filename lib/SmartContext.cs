using System;

namespace App
{
    public class AtomicSession
    {
        private int _state;

        public AtomicSession(int seed) => _state = seed;

        public int flush(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 78) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AtomicSession(78);
            Console.WriteLine(obj.flush(78));
        }
    }
}
