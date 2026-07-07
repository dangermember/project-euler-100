

using System.Drawing;
using System.Numerics;

namespace net.talaatharb.projecteuler100.Core
{

    /**
    * @author mharb
    *
    */
    public class P015 : Solution
    {

        /**
         * Problem solution entry point
         * 
         * @param args
         */
        public static void Main(string[] args)
        {
            new P015().Run();
        }
        public BigInteger factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public override long Solve()
        {
            problemNumber = 15;
            int dimensions = 20;
            return (long)(factorial(2 * dimensions) / (factorial(dimensions) * factorial(dimensions)));
        }
    }
}

