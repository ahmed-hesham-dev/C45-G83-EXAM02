using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.models
{
    public abstract class Question
    {
        protected Question(string? header, string? body, int mark, Answer[]? answerList, Answer? rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }

        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }


        public Answer[]? AnswerList { get; set; }
        public Answer? RightAnswer { get; set; }

    }
}
