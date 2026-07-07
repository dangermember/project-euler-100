

namespace net.talaatharb.projecteuler100.Core
{

    /**
    * @author mharb
    *
    */
    public class P014 : Solution
    {

        /**
         * Problem solution entry point
         * 
         * @param args
         */
        public static void Main(string[] args)
        {
            new P014().Run();
        }

        public override long Solve()
        {
            problemNumber = 14;
            int limit = 1000000;
            int maxCount = 0;
            int maxNumber = 0;
            Dictionary<int, int> list = new();
            for (int i = 1; i < limit; i++)
            {
                int count = 0;
                long n = i;
                while(n != 1)
                {
                    if(n % 2 == 0)
                    {
                        n /= 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    count++;
                    if (list.ContainsKey((int)n))
                    {
                        count += list[(int)n];
                        break;
                    }
                }
                list[i] = count;
                if(count > maxCount)
                {
                    maxCount = count;
                    maxNumber = i;
                }
            }
            return maxNumber;
        }
    }
}

