using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter19
{
    class TrailingZeros19_3
    {
        static int TrailingZeros(int n)
        {
            if (n < 0)
                return 0;
            int cnt = 0;

            for (int i = 5; n / i > 0; i *= 5)
                cnt += (n/i);

            return cnt;
        }

        public static void driver()
        {
            int[] arr = { 30, 91, 94, 99, 100 };
            foreach (int i in arr)
                Console.WriteLine("Trailing 0's = {0}", TrailingZeros(i));            
        }
    }
}
