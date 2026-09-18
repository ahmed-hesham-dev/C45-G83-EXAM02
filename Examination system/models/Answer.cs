using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.models
{
    public class Answer
    {
        public Answer(int answerId, string? answerName)
        {
            AnswerId = answerId;
            AnswerName = answerName;
        }

        public int AnswerId { get; set; }
        public string? AnswerName { get;set; }

    }
}
