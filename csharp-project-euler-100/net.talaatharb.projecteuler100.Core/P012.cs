

namespace net.talaatharb.projecteuler100.Core
{

    /**
    * @author mharb
    *
    */
    public class P012 : Solution
    {

        /**
         * Problem solution entry point
         * 
         * @param args
         */
        public static void Main(string[] args)
        {
            new P012().Run();
        }
        private static int GetDevisors(int n)
        {
            int count = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    count += 2; // i and n/i
                }
            }
            if (Math.Sqrt(n) % 1 == 0) // perfect square
            {
                count--;
            }
            return count;
        }
        public override long Solve()
        {
            problemNumber = 12;
            int targetDivisorCount = 500;

            int triangleNumber = 0;
            int i = 1;
            while (true)
            {
                triangleNumber += i;
                if (GetDevisors(triangleNumber) > targetDivisorCount)
                {
                    return triangleNumber;
                }
                i++;
            }
        }
    }
}

