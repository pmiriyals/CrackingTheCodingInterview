using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter1
{
    class IsUniqueChar1_1
    {
        //O(n) with extra space
        static void IsUniqueUsingCountArray(string s)
        {
            int[] cnt = new int[256];
            bool isunique = true;

            foreach (char c in s)
            {
                if (cnt[c] != 0)
                {
                    isunique = false;
                    break;
                }
                cnt[c] = 1;
            }
            Console.WriteLine("\nUsing Count Array: ");
            if (isunique)
                Console.WriteLine("All characters in given string are unique");
            else
                Console.WriteLine("Found duplicate characters");
        }

        //O(n) with constant space (almost)
        static void IsUniqueUsingBitVector(string s)
        {
            int size = 32;
            int num = 256 / size; //groups (4 bytes), 0 to 255 characters
            int[] bitVector = new int[num]; //8*4 bytes = 32 bytes (compared to 256*4 bytes used in count array)
            bool isunique = true;

            foreach (char c in s)
            {
                int grp = c / size;
                int bit = (1 << (c % size)); //(c%size) is a number between [0 to 31], each integer is 4 bytes (32 bits), use each bit to represent a char

                if ((bitVector[grp] & bit) == 0)
                {
                    bitVector[grp] |= bit;
                }
                else
                {
                    isunique = false;
                    break;
                }
            }
            Console.WriteLine("\nUsing Bit Vector: ");
            if (isunique)
                Console.WriteLine("All characters in given string are unique");
            else
                Console.WriteLine("Found duplicate characters");
        }

        //O(n2)
        static void IsUniqueUsingNaive(string s)
        {
            bool isunique = true;

            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        isunique = false;
                        break;
                    }
                }
            }

            Console.WriteLine("\nUsing Naive approach: ");
            if (isunique)
                Console.WriteLine("All characters in given string are unique");
            else
                Console.WriteLine("Found duplicate characters");
        }

        //O(n log n): modifies the original string
        static void IsUniqueUsingSorting(string s)
        { }

        //Same as count array
        static void IsUniqueUsingHashSet(string s)
        { }
        
        public static void driver()
        {
            string s = "tes h\ti$;";
            IsUniqueUsingBitVector(s);
            IsUniqueUsingCountArray(s);
            IsUniqueUsingNaive(s);
        }
    }
}
