using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignmentDay5
{
    class Program3
    {
        static void Main()
        {
            Console.WriteLine("Enter the No of Students");
            int size = Convert.ToInt32(Console.ReadLine());

            Student[] std = new Student[size];

            Console.WriteLine("Enter Students Details : ");
            for (int i = 0; i < std.Length; i++)
            {
                Console.WriteLine("Enter the roll no :");
                int rn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name :");
                string nm = Console.ReadLine();
                Console.WriteLine("Enter the mark :");
                decimal m = Convert.ToDecimal(Console.ReadLine());

                Student obj = new Student(rn, nm, m);
                std[i] = obj;
            }

            Console.WriteLine("Students Details : ");
            for (int i = 0; i < std.Length; i++)
            {
                std[i].Show();
            }

            Console.ReadLine();
        }
    }

    struct Student
    {
        public int rollNo;
        public string stdName;
        public decimal stdMarks;

        public int RollNo
        {
            set
            {
                if (value > 100 && value < 1000)
                    rollNo = value;
                else
                    Console.WriteLine("Invalid Input");
            }
            get
            {
                return rollNo;
            }
        }
        public string StdName
        {
            set
            {
                if (value != null)
                    stdName = value;
                else
                    Console.WriteLine("Invalid Input");
            }
            get
            {
                return stdName;
            }
        }
        public decimal StdMarks
        {
            set
            {
                if (value >= 0 && value <= 100)
                    stdMarks =  value;
                else
                    Console.WriteLine("Invalid Input");
            }
            get
            {
                return stdMarks;
            }
        }

        public Student(int RollNo, string StdName, decimal StdMarks) :this()
        {
            this.RollNo = RollNo;
            this.StdName = StdName;
            this.StdMarks = StdMarks;
        }

        public void Show()
        {
            Console.WriteLine("Roll No :"+RollNo);
            Console.WriteLine("Name : "+StdName);
            Console.WriteLine("Marks : "+StdMarks);
        }
    }
}
