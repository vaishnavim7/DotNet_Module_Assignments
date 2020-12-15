using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignmentDay5
{
    class Program
    {
        static void Main1()
        {
            Console.Write("Enter the num of employees : ");
            int empNo = Convert.ToInt32(Console.ReadLine());

            Employee[] emp = new Employee[empNo];
            for (int i = 0; i < emp.Length; i++)
            {
                //taking inputs
                Console.WriteLine("Enter Emp Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Emp Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Emp Salary");
                decimal sal = Convert.ToDecimal(Console.ReadLine());

                //Emp Constructor
                Employee obj = new Employee(id, name, sal);
                emp[i] = obj;
            }

            //display details
            Console.WriteLine("===============================");
            Console.WriteLine("Employee Details :");
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i].Display();
            }
            Console.WriteLine("===============================");
            Console.WriteLine("Employee with Highest Salary :");
            decimal max = emp[0].EmpSal;
            for (int i = 0; i < emp.Length; i++)
            {
                if(emp[i].EmpSal > max)
                {
                    max = emp[i].EmpSal;
                }
            }

            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i].EmpSal == max)
                {
                    emp[i].Display();
                }
            }

            Console.WriteLine("===============================");
            Console.WriteLine("Enter Emp Id :");
            int empId = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i].EmpID == empId)
                {
                    emp[i].Display();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpID;
        public string EmpName;
        public decimal EmpSal;

        public Employee(int EmpID, string EmpName, decimal EmpSal)
        {
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.EmpSal = EmpSal;
        }

        public void Display()
        {
            Console.WriteLine("Emp ID :"+EmpID);
            Console.WriteLine("Emp Name :"+EmpName);
            Console.WriteLine("Emp Sal :"+EmpSal);
        }
    }
}
