using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignmentDay8
{
    class Program
    {
        static void Main()
        {
            //Simple Interest
            Func<decimal, decimal, decimal, decimal> si = (p, r, t) => 
            {
                decimal res;
                res = (p * r * t) / 100;
                return res;
            };
            Console.WriteLine("Simple Interst : "+si(7, 2, 10));

            //Greater Num
            Func<int, int, bool> gr = (num1, num2) =>
            {
                    return num1 > num2;
            };
            Console.WriteLine("Greater Num : " + gr(2, 7));

            //Basic Salary
            Func<decimal ,decimal> bs = (sal) =>
            {
                decimal HRA = ((sal * 3) / 100);
                decimal TA = ((sal * 4) / 100);
                decimal IT = ((sal * 5) / 100);
                decimal PF = ((sal * 4) / 100);
                decimal NetSalary = sal + HRA + TA - PF - IT;
                return NetSalary;
            };
            Console.WriteLine("Salary : " + bs(15000));

            //IsEven Num
            Func<int, bool> evn = (num) =>
            {
                return (num%2 == 0);
            };
            Console.WriteLine("Is Even : " + evn(7));

            // IsGreaterThan10000
            Func<int, bool> grt = (num) =>
            {
                return num > 10000;
            };
            Console.WriteLine("Is Greater Than 10000 : " + grt(7000));

            Console.ReadLine();
        }
    }
}
