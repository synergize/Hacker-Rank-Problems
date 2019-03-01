using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankProblems
{
    class Grades
    {
        //Grading Student [Complete]
        public int[] gradingStudents(int[] grades)
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
    }
}
