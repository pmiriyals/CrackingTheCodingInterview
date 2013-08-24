using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter1
{
    class ReplaceSpace1_5
    {
        //C programming style
        static void replaceSpace(char[] arr)
        {
            int spaces = 0;
            foreach (char c in arr)
                if (c == ' ')
                    spaces++;

            char[] str = new char[arr.Length + (spaces * 2)];

            int ndx = 0;

            foreach(char c in arr)
            {
                if (c == ' ')
                {
                    str[ndx++] = '%';
                    str[ndx++] = '2';
                    str[ndx++] = '0';
                }
                else
                    str[ndx++] = c;
            }

            Console.WriteLine( str);
        }
        
        public static void driver()
        {
            string s = "Please replace all spaces with %20";
            char[] str = s.ToCharArray();
            replaceSpace(str);
        }
    }
}
