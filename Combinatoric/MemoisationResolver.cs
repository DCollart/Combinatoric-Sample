using System;

namespace Combinatoric
{
    [Serializable]
    public class MemoisationResolver : RecursiveResolver
    {
        private long?[][] Cache { get; set; }
        public override long Resolve(int amount, int[] values)
        {
            Cache = new long?[amount+1][];
            for (var i = 0; i < Cache.Length; i++)
            {
                Cache[i] = new long?[values.Length+1];
            }
            return base.Resolve(amount, values);
        }

        protected override long ResolveImplementation(int amount, int[] values, int nbValue)
        {
            if (nbValue < 0 || amount < 0)
            {
                return 0;
            }
            if (!Cache[amount][nbValue].HasValue)
            {
                Cache[amount][nbValue] = base.ResolveImplementation(amount, values, nbValue);
            }

            return Cache[amount][nbValue].Value;
        }
    }
}
