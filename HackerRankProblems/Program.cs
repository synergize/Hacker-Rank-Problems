using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            var counter = scores.Distinct().Count() + 1;
            var leaderOutput = new int[alice.Length];
            var checkScores = new int[leaderOutput.Length];

            for (var j = 0; j < alice.Length; j++)
            {
                for (var i = scores.Length - 1; 
                    i >= 0; i--)
                {
                    if (alice[j] < scores[i])
                    {
                        break;
                    }

                    if (alice[j] > scores[i])
                    {
                        counter--;
                        if (i > 0)
                        {
                            if (scores[i] == scores[i - 1])
                            {
                                counter++;
                            }
                        }
                    }

                    if (alice[j] == scores[i])
                    {
                        if (i > 0)
                        {
                            if (alice[j] != scores[i + 1])
                            {
                                counter--;
                            }
                        }
                    }
                    if (alice[j] >= scores.Max())
                    {
                        counter = 1;
                        break;
                    }



                }
                leaderOutput[j] = counter;
                counter = scores.Distinct().Count() + 1;
            }

            for (int i = 0; i < checkScores.Length; i++)
            {
                var checkAnswers = new int[]
                {
                    88, 88, 87, 85, 84, 84, 83, 82, 81, 81, 80, 80, 80, 80, 79, 79, 79, 79, 79, 79, 79, 79, 77, 75, 75,
                    74, 73, 73, 73, 71, 71, 71, 71, 71, 71, 70, 70, 69, 69, 68, 68, 68, 68, 67, 67, 67, 66, 66, 65, 65,
                    64, 64, 62, 61, 61, 60, 59, 59, 59, 59, 59, 59, 58, 57, 56, 56, 55, 55, 53, 52, 52, 51, 51, 51, 51,
                    51, 51, 51, 51, 51, 51, 51, 51, 51, 50, 50, 50, 50, 49, 49, 48, 48, 47, 47, 47, 45, 43, 42, 42, 41,
                    38, 36, 36, 36, 36, 35, 35, 35, 35, 35, 35, 34, 34, 34, 33, 33, 33, 33, 33, 32, 30, 28, 28, 28, 28,
                    27, 27, 27, 26, 23, 23, 22, 22, 20, 20, 20, 18, 18, 15, 15, 14, 14, 13, 13, 11, 11, 10, 10, 8, 8, 7,
                    6, 5, 4, 4, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                    1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1
                };
                checkScores[i] = leaderOutput[i];
                if (checkScores[i] == checkAnswers[i])
                {
                    Console.WriteLine($"{i}: Alice Score Placement: {leaderOutput[i]}. Correct: YES");
                }
                else
                {
                    Console.WriteLine($"{i}: Alice Score Placement: {leaderOutput[i]}. Counter Amount: {checkScores[i]} NOT CORRECT: Should be {checkAnswers[i]}");
                }
            }

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
            //int[] scores = new int[] { 100, 90, 90, 80, 75, 60 };
            //int[] alice = new int[] { 50, 65, 77, 90, 102 };
            //int[] scores = new int[] { 100, 100, 100, 50, 50, 100, 100 };
            //int[] alice = new int[] { 5, 100, 50, 120 };
            int[] scores = new int[] { 295, 294, 291, 287, 287, 285, 285, 284, 283, 279, 277, 274, 274, 271, 270, 268, 268, 268, 264, 260, 259, 258, 257, 255, 252, 250, 244, 241, 240, 237, 236, 236, 231, 227, 227, 227, 226, 225, 224, 223, 216, 212, 200, 197, 196, 194, 193, 189, 188, 187, 183, 182, 178, 177, 173, 171, 169, 165, 143, 140, 137, 135, 133, 130, 130, 130, 128, 127, 122, 120, 116, 114, 113, 109, 106, 103, 99, 92, 85, 81, 69, 68, 63, 63, 63, 61, 57, 51, 47, 46, 38, 30, 28, 25, 22, 15, 14, 12, 6, 4 };
            int[] alice = new int[] { 5, 5, 6, 14, 19, 20, 23, 25, 29, 29, 30, 30, 32, 37, 38, 38, 38, 41, 41, 44, 45, 45, 47, 59, 59, 62, 63, 65, 67, 69, 70, 72, 72, 76, 79, 82, 83, 90, 91, 92, 93, 98, 98, 100, 100, 102, 103, 105, 106, 107, 109, 112, 115, 118, 118, 121, 122, 122, 123, 125, 125, 125, 127, 128, 131, 131, 133, 134, 139, 140, 141, 143, 144, 144, 144, 144, 147, 150, 152, 155, 156, 160, 164, 164, 165, 165, 166, 168, 169, 170, 171, 172, 173, 174, 174, 180, 184, 187, 187, 188, 194, 197, 197, 197, 198, 201, 202, 202, 207, 208, 211, 212, 212, 214, 217, 219, 219, 220, 220, 223, 225, 227, 228, 229, 229, 233, 235, 235, 236, 242, 242, 245, 246, 252, 253, 253, 257, 257, 260, 261, 266, 266, 268, 269, 271, 271, 275, 276, 281, 282, 283, 284, 285, 287, 289, 289, 295, 296, 298, 300, 300, 301, 304, 306, 308, 309, 310, 316, 318, 318, 324, 326, 329, 329, 329, 330, 330, 332, 337, 337, 341, 341, 349, 351, 351, 354, 356, 357, 366, 369, 377, 379, 380, 382, 391, 391, 394, 396, 396, 400 };
            climbingLeaderboard(scores, alice);
            Console.Write("");
        }
    }
}
