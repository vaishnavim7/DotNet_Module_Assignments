using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignmentDay6_1
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

            Dictionary<int, Employee> empD = new Dictionary<int, Employee>();
            for (int i = 0; i < emp.Length; i++)
            {
                empD.Add(i, emp[i]);
            }
            
            //display details
            Console.WriteLine("===============================");
            foreach (KeyValuePair<int, Employee> kv in empD)
            {
                //Console.WriteLine("Key : {0}, Emp Details : {1}", kv.Key, kv.Value);
                Console.WriteLine(kv.Key);
                Console.WriteLine(kv.Value);
            }

            Console.WriteLine("===============================");
            decimal max = emp[0].EmpSal;
            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i].EmpSal > max)
                {
                    max = emp[i].EmpSal;
                }
            }
            Console.WriteLine("Highest Salary : "+max);

            Console.WriteLine("Employee with Highest Salary :");
            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i].EmpSal == max)
                {
                    emp[i].Display();
                }
            }

            Console.WriteLine("===============================");
            Console.WriteLine("Enter Emp Id  to search:");
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
            Console.WriteLine("Emp ID :" + EmpID);
            Console.WriteLine("Emp Name :" + EmpName);
            Console.WriteLine("Emp Sal :" + EmpSal);
        }

        //public override string ToString()
        //{
        //    Console.WriteLine("Emlpoyee details***************************");
        //    return EmpID + " " + EmpName + " " + EmpSal;
        //}
    }
}
