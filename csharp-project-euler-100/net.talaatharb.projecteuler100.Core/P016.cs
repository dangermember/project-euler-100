

using System.Numerics;

namespace net.talaatharb.projecteuler100.Core
{

    /**
    * @author mharb
    *
    */
    public class P016 : Solution
    {

        /**
         * Problem solution entry point
         * 
         * @param args
         */
        public static void Main(string[] args)
        {
            new P016().Run();
        }

        public override long Solve()
        {
            problemNumber = 16;
            BigInteger number = BigInteger.Pow(2, 1000);
            long sum = 0;
            while (number > 0)
            {
                sum += (long)(number % 10);
                number /= 10;
            }
            return sum;
        }
    }
}

