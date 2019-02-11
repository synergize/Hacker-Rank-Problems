using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankProblems
{
    class Program
    {
        // Apples and Oranges Hacker Rank
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int HouseLeft = s;
            int HouseRight = t;
            int AppleTreeLocation = a;
            int OrangeTreeLocation = b;
            int AppleCount = 0;
            int OrangeCount = 0;
            int[] AppleOutAry = new int[apples.Length];
            int[] OrangesOutAry = new int[oranges.Length];
            for (int i = 0; i < apples.Length; i++)
            {
                AppleOutAry[i] = AppleTreeLocation + apples[i];
                if (AppleOutAry[i] >= HouseLeft && AppleOutAry[i] <= HouseRight)               
                    AppleCount++;              
            }
            for (int i = 0; i < oranges.Length; i++)
            {
                OrangesOutAry[i] = OrangeTreeLocation + oranges[i];
                if (OrangesOutAry[i] >= HouseLeft && OrangesOutAry[i] <= HouseRight)                
                    OrangeCount++;
            }
            Console.WriteLine(AppleCount);
            Console.WriteLine(OrangeCount);
        }

        // Counting kangaroo jmps
        static string kangaroo(int x1, int v1, int x2, int v2)
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

        //Grading Student [In Progress]
        static int[] gradingStudents(int[] grades)
        {
            int DivideByFive = 0;
           for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] <)
               DivideByFive = grades[i] / 5;
            }

        }


        static void Main(string[] args)
        {
            // Apples And Oranges Test Input Hacker Rank
            //int[] Apple = new int[] { 2, 3, -4 };
            //int[] Orange = new int[] { 3, -2, -4 };
            //countApplesAndOranges(7, 10, 4, 12, Apple, Orange);

            //Kangaroo Input
            //Console.WriteLine(kangaroo(0, 3, 4, 2));
            //Console.WriteLine(kangaroo(2, 1, 1, 2));

        }
    }
}
