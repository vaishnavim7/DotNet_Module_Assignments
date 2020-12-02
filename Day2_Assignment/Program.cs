﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAssign1
{
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.Show();
            Console.WriteLine("=======================================");
            Employee emp2 = new Employee("avinash", 10000, 10);
            emp2.Show();
            Console.WriteLine("=======================================");
            Employee emp3 = new Employee("ashwin", 12000);
            emp3.Show();
            Console.WriteLine("=======================================");
            Employee emp4 = new Employee("manvi");
            emp4.Show();

            Console.WriteLine("==================Employee No=====================");
            Console.WriteLine("EmpNo for emp obj 1 :"+emp.EmpNo);
            Console.WriteLine("EmpNo for emp obj 2 :" + emp2.EmpNo);
            Console.WriteLine("EmpNo for emp obj 3 :" + emp3.EmpNo);
            Console.WriteLine("EmpNo for emp obj 4 :" + emp4.EmpNo);

            Console.WriteLine("==================Employee No=====================");
            Console.WriteLine("EmpNo for emp obj 4 :" + emp4.EmpNo);
            Console.WriteLine("EmpNo for emp obj 3 :" + emp3.EmpNo);
            Console.WriteLine("EmpNo for emp obj 2 :" + emp2.EmpNo);
            Console.WriteLine("EmpNo for emp obj 1 :" + emp.EmpNo);

            Console.ReadLine();
        }
    }

    public class Employee
    {
        //string Name -> no blank names should be allowed
        private string name;
        public string Name 
        {
            set
            {
                if(value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            get
            {
                return name;
            }
        }

        //int EmpNo -> must be readonly and autogenerated
        static private int lastEmpNo = 0; 
        private int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }

        //decimal Basic -> must be between some range
        private decimal basics;
        public decimal Basics
        {
            set
            {
                if (value > 5000 && value < 50000)
                {
                    basics = value;
                }
                else
                {
                    Console.WriteLine("Inavlid Input");
                }
            }
            get
            {
                return basics;
            }
        }

        //short DeptNo -> must be > 0
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if(value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            get
            {
                return deptNo;
            }
        }

        public Employee()
        {
            Console.WriteLine("No Parametrized Constructor ");
            empNo = lastEmpNo++;
        }

        public Employee(string n = null, decimal s=0, short d=0)
        {
            Console.WriteLine("Parametrized Constructor ");
            name = n;
            empNo = lastEmpNo++;
            basics = s;
            deptNo = d;
        }

        public decimal NetSal()
        {
            decimal netsal = basics * 12;
            return netsal;
        }

        public void Show()
        {
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Basic Salary : "+basics);
            Console.WriteLine("Net Salary : " +NetSal());
            Console.WriteLine("Dept No : "+deptNo);
        }
    }
}