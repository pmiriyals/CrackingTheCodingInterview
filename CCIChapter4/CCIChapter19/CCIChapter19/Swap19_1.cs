using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter19
{
    class Swap19_1
    {
        static void swap(int[] a)
        {
            a[0] = a[0] ^ a[1];
            a[1] = a[0] ^ a[1];
            a[0] = a[0] ^ a[1];
        }

        static void swapArr(int[] a)
        {
            a[0] = a[0] + a[1];
            a[1] = a[0] - a[1];
            a[0] = a[0] - a[1];
        }
        
        public static void driver()
        {
            int[] a = {10, 20};
            swap(a);
            Console.Write("a[0] = {0}\na[1] = {1}", a[0], a[1]);
            swapArr(a);
            Console.Write("a[0] = {0}\na[1] = {1}", a[0], a[1]);
        }
    }
}
