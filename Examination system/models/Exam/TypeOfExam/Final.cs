using Examination_system.models;
using Examination_system.models.Exam;
using System;
using System.Diagnostics;
using System.Timers;

public class FinalExam : Exam
{
    public FinalExam(int time, int numberOfQuestions, Question[] questions)
        : base(time, numberOfQuestions, questions)
    {
    }

    public override void ShowExam()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        int totalMark = 0;
        int studentMark = 0;

        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("          FINAL EXAM");
        Console.WriteLine("================================");
        Console.WriteLine();

        for (int i = 0; i < Questions.Length; i++)
        {
            Question question = Questions[i];

            Console.WriteLine($"Question {i + 1}");
            Console.WriteLine(question.Body);
            Console.WriteLine($"Mark: {question.Mark}");
            Console.WriteLine();

            foreach (Answer answer in question.AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId}. {answer.AnswerName}");
            }

            Console.WriteLine();
            Console.Write("Your Answer: ");

            int studentAnswer = int.Parse(Console.ReadLine());

            if (studentAnswer == question.RightAnswer.AnswerId)
            {
                studentMark += question.Mark;
            }

            totalMark += question.Mark;

            Console.WriteLine();
        }

        stopwatch.Stop();

        TimeSpan elapsed = stopwatch.Elapsed;

        Console.Clear();

        Console.WriteLine("================================");
        Console.WriteLine("          EXAM RESULT");
        Console.WriteLine("================================");
        Console.WriteLine($"Exam Type       : Final Exam");
        Console.WriteLine($"Exam Time       : {Time} minutes");
        Console.WriteLine($"Questions       : {NumberOfQuestions}");
        Console.WriteLine($"Time Taken      : {elapsed.Minutes} minutes {elapsed.Seconds} seconds");
        Console.WriteLine($"Your Grade      : {studentMark} / {totalMark}");
        Console.WriteLine("================================");
    }

    public override string ToString()
    {
        return $"Final Exam - Time: {Time} minutes, Number of Questions: {NumberOfQuestions}";
    }
}