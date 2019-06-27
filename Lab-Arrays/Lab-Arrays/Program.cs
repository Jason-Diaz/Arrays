using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Arrays
{
    class Program
    {
        static void Display(double[] arr)
        {
            foreach (double i in arr)
            {
                
                System.Console.Write(i + " ");
               
            }
            System.Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            double[] Num = new double[4] { 4.4, 7.7, 1, 2.3 };
            Display(Num);

            Array.Sort(Num);
            Display(Num);

            double[] Clone = (double[])Num.Clone();
            Display(Clone);

            Grade[] Grades = new Grade[4];
            Grades[0] = new Grade(50.5,"Test");
            Grades[1] = new Grade(70.5, "Quiz");
            Grades[2] = new Grade(80.6, "Lab");
            Grades[3] = new Grade(40.3, "Part");
            
            foreach (Grade i in Grades)
            {
                string s = i.toString();
                System.Console.WriteLine(s);
            }
            Array.Sort(Grades);

            System.Console.WriteLine();

            foreach (Grade i in Grades)
            {
                string s = i.toString();
                System.Console.WriteLine(s);
            }
        }
    }
}
