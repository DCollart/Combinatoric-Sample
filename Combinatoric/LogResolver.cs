using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Combinatoric
{
    [Serializable]
    public class LogResolver : ICombinatoricResolver
    {
        private readonly ICombinatoricResolver _resolver;

        public LogResolver(ICombinatoricResolver resolver)
        {
            _resolver = resolver;
        }

        public long Resolve(int amount, int[] values)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long sum = _resolver.Resolve(amount, values);
            stopwatch.Stop();

            long size;
            using (Stream s = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, this);
                size = s.Length;
            }

            Console.WriteLine($"{_resolver.GetType().Name} => Result : {sum}, temps = {stopwatch.ElapsedMilliseconds} ms, ticks = {stopwatch.ElapsedTicks}, size = {size}");
            return sum;
        }
    }
}
