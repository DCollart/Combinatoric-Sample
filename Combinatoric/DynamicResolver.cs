using System;

namespace Combinatoric
{
    [Serializable]
    public class DynamicResolver : ICombinatoricResolver
    {
        private long[] Amounts { get; set; }

        public long Resolve(int amount, int[] values)
        {
            Amounts = new long[amount];
            checked
            {
                for (int i = 0; i < values.Length; i++)
                {
                    for (int j = 0; j < Amounts.Length; j++)
                    {
                        if ((j + 1) == values[i])
                        {
                            Amounts[j]++;
                        }
                        if (((j + 1) - values[i]) > 0)
                        {
                            Amounts[j] += Amounts[j - values[i]];
                        }
                    }
                }

                return Amounts[amount - 1];
            }
        }
    }
}
