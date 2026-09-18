using Examination_system.models;
using Examination_system.models.Exam;
using Examination_system.models.Exam;
using Examination_system.models.Exam;
using System;

class Program
{
    static void Main()
    {
        Subject subject = new Subject();

        Console.WriteLine("================================");
        Console.WriteLine("       EXAMINATION SYSTEM");
        Console.WriteLine("================================");
        Console.WriteLine();

        Console.Write("Enter Subject ID: ");
        subject.SubjectId = int.Parse(Console.ReadLine());

        Console.Write("Enter Subject Name: ");
        subject.SubjectName = Console.ReadLine();

        int examType;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Choose Exam Type:");
            Console.WriteLine("1. Final Exam");
            Console.WriteLine("2. Practical Exam");
            Console.Write("Enter choice: ");

            examType = int.Parse(Console.ReadLine());

        } while (examType != 1 && examType != 2);

        int time;

        do
        {
            Console.Write("Enter Exam Time (30 - 180 minutes): ");
            time = int.Parse(Console.ReadLine());

        } while (time < 30 || time > 180);

        int numberOfQuestions;

        do
        {
            Console.Write("Enter Number Of Questions: ");
            numberOfQuestions = int.Parse(Console.ReadLine());

        } while (numberOfQuestions <= 0);

        Question[] questions = new Question[numberOfQuestions];

        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine($"Question {i + 1}");
            Console.WriteLine("================================");

            int questionType = 2;

            if (examType == 1)
            {
                do
                {
                    Console.WriteLine("Choose Question Type:");
                    Console.WriteLine("1. True / False");
                    Console.WriteLine("2. MCQ");
                    Console.Write("Enter choice: ");

                    questionType = int.Parse(Console.ReadLine());

                } while (questionType != 1 && questionType != 2);
            }

            Console.Write("Enter Header: ");
            string header = Console.ReadLine();

            Console.Write("Enter Body: ");
            string body = Console.ReadLine();

            int mark;

            do
            {
                Console.Write("Enter Mark: ");
                mark = int.Parse(Console.ReadLine());

            } while (mark <= 0);

            Answer[] answers;

            if (questionType == 1)
            {
                answers = new Answer[]
                {
                    new Answer(1, "True"),
                    new Answer(2, "False")
                };
            }
            else
            {
                answers = new Answer[4];

                for (int j = 0; j < answers.Length; j++)
                {
                    Console.Write($"Enter Answer {j + 1}: ");
                    string answerText = Console.ReadLine();

                    answers[j] = new Answer(j + 1, answerText);
                }
            }

            int rightAnswerId;

            do
            {
                Console.Write("Enter Right Answer Number: ");
                rightAnswerId = int.Parse(Console.ReadLine());

            } while (rightAnswerId < 1 || rightAnswerId > answers.Length);

            Answer rightAnswer = answers[rightAnswerId - 1];

            if (questionType == 1)
            {
                questions[i] = new TrueFalseQuestion(
                    header,
                    body,
                    mark,
                    answers,
                    rightAnswer
                );
            }
            else
            {
                questions[i] = new MCQQuestion(
                    header,
                    body,
                    mark,
                    answers,
                    rightAnswer
                );
            }
        }

        Exam exam;

        if (examType == 1)
        {
            exam = new FinalExam(
                time,
                numberOfQuestions,
                questions
            );
        }
        else
        {
            exam = new PracticalExam(
                time,
                numberOfQuestions,
                questions
            );
        }

        subject.CreateExam(exam);

        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("       EXAM INFORMATION");
        Console.WriteLine("================================");
        Console.WriteLine($"Subject ID      : {subject.SubjectId}");
        Console.WriteLine($"Subject Name    : {subject.SubjectName}");
        Console.WriteLine($"Exam Type       : {(examType == 1 ? "Final Exam" : "Practical Exam")}");
        Console.WriteLine($"Exam Time       : {time} minutes");
        Console.WriteLine($"Questions       : {numberOfQuestions}");
        Console.WriteLine("================================");

        Console.WriteLine();
        Console.Write("Do you want to take the exam? (Y/N): ");
        string choice = Console.ReadLine();

        if (choice.ToUpper() == "Y")
        {
            subject.Exam.ShowExam();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Exam was not started.");
        }
    }
}