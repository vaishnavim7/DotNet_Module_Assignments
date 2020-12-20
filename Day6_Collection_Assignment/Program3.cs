using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignmentDay6_3
{
    class Program3
    {
        static void Main()
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee();
            Employee obj3 = new Employee();

            //List
            List<Employee> empL = new List<Employee>();
            obj1.Set(101, "Riva", 15000);
            empL.Add(obj1);

            obj2.Set(102, "Riva", 14000);
            empL.Add(obj2);

            obj3.Set(103, "Shiva", 17000);
            empL.Add(obj3);

            //Array
            Employee[] emp = empL.ToArray();

            //display details
            Console.WriteLine("===============================");
            Console.WriteLine("Employee Details");
            foreach (Employee arr in emp)
            {
                Console.WriteLine(arr);
            }
            
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpID;
        public string EmpName;
        public decimal EmpSal;

        public void Set(int EmpID, string EmpName, decimal EmpSal)
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
