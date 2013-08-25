using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter19
{
    class MasterMinds
    {
        class Result
        {
            public int hits {get; set;}
            public int pseudoHits {get; set;}
            public Result()
            {
                hits = 0;
                pseudoHits = 0;
            }
        }

        static Result FindHits(string soln, string guess)
        {
            int[] cnt = new int[256];
            foreach (char c in soln)
                cnt[c]++;

            Result res = new Result();

            for (int i = 0; i < guess.Length; i++)
            {
                if (cnt[guess[i]] > 0)   //current char in soln is present in guess word
                {
                    if (i < soln.Length && soln[i] == guess[i])
                        res.hits++;
                    else
                        res.pseudoHits++;
                }
            }

            return res;
        }

        public static void driver()
        {
            Result res = FindHits("RGGB", "YRGB");
            Console.WriteLine("Hits = {0}\nPsuedo Hits = {1}", res.hits, res.pseudoHits);
        }
    }
}
