using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignmentDay5
{
    class Program2
    {
        static void Main1()
        {
            Console.Write("Enter the num of Batches : ");
            int batchNo = Convert.ToInt32(Console.ReadLine());
            int[][] batch = new int[batchNo][];

            for (int i = 0; i < batch.Length; i++)
            {
                //taking inputs
                Console.WriteLine("Enter Size of batches");
                int batchSize = Convert.ToInt32(Console.ReadLine());
                batch[i] = new int[batchSize]; 

            }

            //taking input
            for (int i = 0; i < batch.Length; i++)
            {
                for (int j = 0; j < batch[i].Length; j++)
                {
                    Console.WriteLine("enter marks for students [{0}][{1}] ", i, j);
                    batch[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //display details
            Console.WriteLine("===============================");
            Console.WriteLine("Batch Details :");
            for (int i = 0; i < batch.Length; i++)
            {
                for (int j = 0; j < batch[i].Length; j++)
                {
                    Console.WriteLine("marks of students {0} and {1}  is {2}", i, j, batch[i][j]);
                }
            }

            Console.ReadLine();
        }
    }
 }
