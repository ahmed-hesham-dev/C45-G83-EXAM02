using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.models.Exam.TypeOfExam
{
    internal class Final : Exam
    {
        public Final(int time, int numberOfQuestions, Question[]? questions) : base(time, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {

                Console.WriteLine($"Body: {question.Body}");
                Console.WriteLine($"Grade: {question.Mark}");

                foreach (Answer answer in question.AnswerList)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerName}");
                }
            }
        }
    }
}