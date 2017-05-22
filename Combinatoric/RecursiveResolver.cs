using System;

namespace Combinatoric
{
    [Serializable]
    public class RecursiveResolver : ICombinatoricResolver
    {
        public virtual long Resolve(int amount, int[] values)
        {
            return ResolveImplementation(amount,values,values.Length-1);
        }

        protected virtual long ResolveImplementation(int amount, int[] values, int nbValue)
        {
            checked
            {
                long result;
                if (amount <= 0)
                {
                    return 0;
                }
                else if (nbValue < 0)
                {
                    return 0;
                }
                else
                {
                    result = ((amount == values[nbValue]) ? 1 : 0);
                    result += (ResolveImplementation(amount, values, nbValue - 1) +
                               ResolveImplementation((amount - (values[nbValue])), values, nbValue));
                }
                return result;
            }
        }
    }
}
