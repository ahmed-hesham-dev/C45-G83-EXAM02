using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.models
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string? header, string? body, int mark, Answer[]? answerList, Answer? rightAnswer) 
            : base(header, body, mark, answerList, rightAnswer)
        {
        }
    }
}
