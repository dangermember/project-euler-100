

namespace net.talaatharb.projecteuler100.Core
{

    /**
    * @author mharb
    *
    */
    public class P017 : Solution
    {

        /**
         * Problem solution entry point
         * 
         * @param args
         */
        public static void Main(string[] args)
        {
            new P017().Run();
        }
        List<string> ones = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        List<string> teens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
        List<string> tens = ["twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
        List<string> hundreds = ["onehundred", "twohundred", "threehundred", "fourhundred", "fivehundred", "sixhundred", "sevenhundred", "eighthundred", "ninehundred"];
        private string NumberToText(int number)
        {
            List<string> output = [];
            int hundredsValue = number / 100;
            int tensValue = number / 10 % 10;
            int onesValue = number % 10;
            if(number == 1000)
            {
                return "onethousand";
            }
            if (hundredsValue > 0)
            {
                output.Add(hundreds[hundredsValue - 1]);
            }
            if (tensValue >= 2)
            {
                output.Add(tens[tensValue - 2] + (onesValue > 0 ? ones[onesValue - 1] : ""));
            }
            else if (tensValue == 1)
            {
                output.Add(teens[onesValue]);
            }
            else if (tensValue == 0 && onesValue > 0) {
                output.Add(ones[onesValue-1]);
            }

            // Implementation for converting number to text
            return string.Join("and", output);
        }

        public override long Solve()
        {
            problemNumber = 17;
            long sum = 0;
            for(int i = 1; i <= 1000; i++)
            {
                sum+= NumberToText(i).Length;
            }
            return sum;
        }
    }
}

