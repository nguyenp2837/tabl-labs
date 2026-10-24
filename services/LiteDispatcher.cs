using System;

namespace App
{
    public class AtomicGateway
    {
        private int _state;

        public AtomicGateway(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 92) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AtomicGateway(92);
            Console.WriteLine(obj.dispatch(92));
        }
    }
}
