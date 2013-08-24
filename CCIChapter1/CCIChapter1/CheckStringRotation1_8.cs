using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter1
{
    class CheckStringRotation1_8
    {
        static bool IsSubstring(string a, string b)
        { 
            return a.IndexOf(b) >= 0 ? true : false;
        }

        static bool IsRotation(string a, string b)
        {
            if (a == null || b == null)
                return false;

            if (a.Length != b.Length)
                return false;
                        
            return IsSubstring(a + a, b);
        }

        public static void driver()
        {
            string a = "ringrotate st";
            string b = "rotate string";
            Console.WriteLine("IsRotation = {0}", IsRotation(a, b));
        }
    }
}
