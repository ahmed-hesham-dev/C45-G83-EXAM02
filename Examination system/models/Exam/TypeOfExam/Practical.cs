using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.models.Exam.TypeOfExam
{
    internal class Practical: Exam          
    {
        public Practical(int time, int numberOfQuestions, Question[]? questions) : base(time, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("This is a practical exam.");

            foreach (var question in Questions)
            {
                Console.WriteLine(question.Body);

                Console.WriteLine($"Right Answer: {question.RightAnswer?.AnswerName}");
    
            }


        }
    }
}
