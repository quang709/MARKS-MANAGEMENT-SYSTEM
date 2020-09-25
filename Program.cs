using System;
using System.Collections;

namespace MARKS_MANAGEMENT_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;


            Console.WriteLine("Please select an option");

            Console.WriteLine("1.Insert new student:");
            Console.WriteLine("2.View list of student:");
            Console.WriteLine("3.Average Mark:");
            Console.WriteLine("4.Exit:");
            do
            {
                Console.WriteLine("Option:");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.insert();
                        break;
                    case 2:
                        program.View();
                        break;
                    case 3:
                        program.avegare();
                        break;
                    case 4: return;


                }


            }
            while (choice != 4);
        }
        int count = 0;
        Hashtable ListStudent = new Hashtable();

        public void insert()
        {
            StudentMarkv studentMarkv = new StudentMarkv();
            studentMarkv.ID = ++count;
            
            Console.WriteLine("pls input student fullname:");
            studentMarkv.FullName = Console.ReadLine(); 
            Console.WriteLine("pls input class name:");
            studentMarkv.Class = Console.ReadLine();
            Console.WriteLine("pls input semester:");
            studentMarkv.Semester = Int32.Parse(Console.ReadLine());
            ListStudent.Add(count, studentMarkv);

            foreach(StudentMarkv item in ListStudent.Values)
            {
                item.AveCal();
            }

        } 




        public void View()
        {
            foreach (StudentMarkv item in ListStudent.Values)
            {
                item.Display();
            }
        }

        public void  avegare()
        {
            foreach (StudentMarkv item in ListStudent.Values)
            {
                item.AveCal();
                item.Display();
            }

        }
    }
}
