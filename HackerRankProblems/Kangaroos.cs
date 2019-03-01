using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankProblems
{
    class Kangaroos
    {
        // Counting kangaroo jumps [Complete]
        public string kangaroo(int x1, int v1, int x2, int v2)
        {
            int count = 0;
            int x = 0;
            int v = 0;
            x += x2;
            v += x1;
            while (count <= 10000)
            {
                x += v2;
                v += v1;
                ++count;

                if (x == v)
                {
                    return "YES";
                }
            }

            return "NO";

        }
    }
}
