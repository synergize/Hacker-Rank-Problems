using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HackerRankProblems
{
    class Program
    {
        // Apples and Oranges Hacker Rank [Complete]
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

        // Counting kangaroo jumps [Complete]
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

        //Grading Student [Complete]
        static int[] gradingStudents(int[] grades)
        {
            int FailingGrade = 38;
            for (int i = 0; i < grades.Length; i++)
            {
                 var DivideByFive = (int)Math.Round(grades[i] / 5.0) * 5;
                var Difference = DivideByFive - grades[i];
                 if (Difference < 3 && Difference > 0 && grades[i] >= FailingGrade)
                    grades[i] = DivideByFive;
            }

            return grades;
        }

        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            var counter = scores.Distinct().Count();
            var leaderOutput = new int[alice.Length];

            for (var j = 0; j < alice.Length; j++)
            {

                for (var i = scores.Distinct().Count(); i >= 0; i--)
                {
                    if (alice[j] > scores[i])
                    {
                        counter--;
                    }

                    if (alice[j] >= scores.Max())
                    {
                        counter = 1;
                        break;
                    }

                }
                leaderOutput[j] = counter;
                counter = scores.Distinct().Count();
                Console.WriteLine($"Alice Score Placement: {leaderOutput[j]}");
            }

            //var aliceCount = 0;
            //var scoresCount = 0;
            //while (loopCounter < alice.Length)
            //{
            //    while (scoresCount <= scores.Distinct().Count())
            //    {
            //        if (alice[aliceCount] < scores[scoresCount])
            //        {
            //            counter++;
            //        }

            //        if (alice[aliceCount] >= scores.Max())
            //        {
            //            counter++;
            //            break;
            //        }
            //        scoresCount++;
            //    }
            //    leaderOutput[aliceCount] = counter;
            //    Console.WriteLine($"Output: {leaderOutput[aliceCount]}");
            //    counter = 0;
            //    aliceCount++;
            //    loopCounter++;
            //    scoresCount = 0;
            //}

            return leaderOutput;

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

            //Grades Input
            //int[] grades = new int[] { 73, 67, 38, 33 };
            //Console.WriteLine(gradingStudents(grades));

            //Score Board Input
            //int[] scores = new int[] { 100, 100, 50, 40, 40, 20, 10 };
            //int[] alice = new int[] { 5, 25, 50, 120 };
            int[] scores = new int[] { 100, 90, 90, 80, 75, 60 };
            int[] alice = new int[] { 50, 65, 77, 90, 102 };
            climbingLeaderboard(scores, alice);
        }
    }
}
