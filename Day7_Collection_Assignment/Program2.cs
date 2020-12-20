using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignmentDay6_2
{
    class Program2
    {
        static void Main2()
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

            List<Employee> empL = emp.ToList<Employee>();
            //display details
            Console.WriteLine("===============================");
            Console.WriteLine("Employee Details");
            foreach (Employee list in empL)
            {
                Console.WriteLine(list);
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

        public override string ToString()
        {
            return EmpID+" "+EmpName+" "+EmpSal;
        }
    }
}
