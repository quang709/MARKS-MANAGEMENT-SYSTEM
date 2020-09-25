using System;
using System.Collections.Generic;
using System.Text;

namespace MARKS_MANAGEMENT_SYSTEM
{
    public class StudentMarkv : IStudentMark
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public string Class { get; set; }
        public int Semester { get; set; }
        public float AverageMark { get; set; }

        public void Display()
        {
            Console.WriteLine($"{FullName} {ID} {Class} {Semester} {AverageMark}");
        }
        int[] SubjectMarkList = new int[5];

        public void AveCal()
        
        {
            AverageMark = (SubjectMarkList[0] + SubjectMarkList[0] + SubjectMarkList[0]) / 5;
        }
    }
}
