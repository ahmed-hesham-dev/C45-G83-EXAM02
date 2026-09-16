using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.models.Exam
{
    public abstract class Exam
    {
        protected Exam(int time, int numberOfQuestions, Question[]? questions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }


        public Question[]? Questions{ get; set; }

        public virtual void ShowExam() { }
       

    }
}
