using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = {1,2,45,67 };
            //int[] arr1 = new int[] { 1, 2, 34, 566, 77 };
            //int[] arr2 = new int[5] { 100, 200, 300, 400, 500 };

            //for (int i = 0; i < arr.Length; i++)
            //{

            //    Console.WriteLine(arr[i]);
            //}

            //Accepted for all types of collections
            //foreach (int element in arr2) {
            //    Console.WriteLine(element);


            //}

            //Array fArray=Array.CreateInstance(typeof(float), 5);
            //fArray.SetValue(10.0f, 0);
            //fArray.SetValue(11.0f, 1);
            //fArray.SetValue(12.0f, 2);
            //fArray.SetValue(13.0f, 3);
            //fArray.SetValue(14.0f, 4);

            ////object o=fArray.GetValue(0);
            ////Console.WriteLine(o);

            //for(int i = 0; i < fArray.Length; i++)
            //{
            //    Console.WriteLine(fArray.GetValue(i));
            //}
            //Console.WriteLine("--------------");
            //foreach (float i in fArray)
            //{
            //    Console.WriteLine(i);


            //}

            //Jagged Array---Array of Array
            //5 th grade
            //4 Divisions=A-4,B=2,C=5,D=1

            //int[][] studentsInDivision = new int[4][];
            //studentsInDivision[0] = new int[4] {1,2,3,4 };
            //studentsInDivision[1] = new int[2] {10,20 };
            //studentsInDivision[2] = new int[5] {100,200,300,400,500 };
            //studentsInDivision[3] = new int[1] { 1000 };


            int[][] studentsInDivision = new int[4][] {
            new int[4] {1,2,3,4 },
            new int[2] {10,20 },
            new int[5] {100,200,300,400,500 },
            new int[1] { 1000 }
            };
            for (int i = 0; i < studentsInDivision.Length; i++) 
            {
                for (int j = 0; j < studentsInDivision[i].Length; j++)
                {
                    Console.Write(studentsInDivision[i][j] + "\t");
                
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");
            foreach (var item in studentsInDivision)
            {
                foreach (var element in item)
                {
                    Console.Write(element + "\t");
                }
                Console.WriteLine();
            }


            Console.Read();


        }
    }
}
