using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatoric
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pieces = { 2, 3, 4, 1, 6, 8, 7, 9, 12, 15 };
            int amount = 150;

            ICombinatoricResolver resolver;

            resolver = new LogResolver(new RecursiveResolver());
            resolver.Resolve(amount, pieces);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            resolver = new LogResolver(new MemoisationResolver());
            resolver.Resolve(amount, pieces);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            resolver = new LogResolver(new DynamicResolver());
            resolver.Resolve(amount, pieces);

            Console.ReadKey();
        }
    }
}
