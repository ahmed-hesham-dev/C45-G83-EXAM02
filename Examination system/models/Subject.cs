using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.models.Exam
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }


    }
}
