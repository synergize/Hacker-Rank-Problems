using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankProblems
{
    class ScoreBoard
    {
        public int[] climbingLeaderboard(int[] scores, int[] alice)
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
                    if (alice[j] == scores[i])
                    {
                        counter--;
                        if (i < scores.Length - 1)
                        {
                            // Checks behind one on Scores to determine if it's a duplicate when alice is equal to it. If it's a duplicate, we add back to the counter. We also decrease the iteration of scores to skip looping through an element
                            // we already checked and don't need to modify. 
                            if (alice[j] == scores[i + 1])
                            {
                                counter++;
                                i--;
                                break;
                            }
                        }
                    }
                    if (alice[j] > scores[i])
                    {
                        counter--;
                        if (i > 0)
                        {
                            // Checks ahead one element on the score board. If it's equal to the current then we add a counter to negate the previous reduction of the counter.
                            if (scores[i] == scores[i - 1])
                            {
                                counter++;
                            }
                        }
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
                //var checkAnswers = new int[]
                //{
                //    97, 96, 94, 94, 94, 94, 89, 87, 87, 86, 83, 83, 83, 83, 83, 81, 81, 81, 80, 80, 80, 80, 76, 76, 76,
                //    76, 75, 74, 73, 73, 73, 72, 72, 72, 72, 72, 72, 71, 70, 70, 70, 70, 69, 69, 69, 67, 67, 66, 63, 63,
                //    63, 63, 63, 63, 63, 63, 61, 59, 59, 57, 57, 57, 54, 52, 52, 51, 50, 49, 48, 47, 47, 47, 47, 47, 47,
                //    47, 47, 47, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 45, 45, 45, 45, 45, 44, 44, 44, 43, 43, 41,
                //    39, 38, 38, 38, 37, 37, 37, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 32, 32,
                //    32, 32, 32, 32, 31, 31, 31, 30, 30, 30, 30, 30, 30, 29, 29, 29, 28, 27, 27, 27, 25, 24, 24, 24, 24,
                //    24, 24, 24, 21, 19, 19, 19, 19, 18, 17, 17, 16, 16, 16, 16, 16, 16, 15, 15, 15, 14, 14, 13, 13, 12,
                //    12, 11, 10, 10, 10, 10, 10, 9, 9, 8, 8, 6, 6, 6, 5, 4, 4, 4, 3, 3, 3, 2, 2, 2, 2
                //};
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
    }
}
