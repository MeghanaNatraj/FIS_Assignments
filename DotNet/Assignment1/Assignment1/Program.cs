using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Assgn1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the size of array: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];

            //Console.WriteLine("Enter the array elements: ");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Sum1 s1 = new Sum1();
            //double average = s1.ArrayEle(arr);

            //s1.MinMax(arr);
            //Console.WriteLine("The average of the array elements are: " + average);

            //Sum2 s2 = new Sum2();
            //int[] m = s2.Marks();
            //s2.Operations(m);

            Console.WriteLine("Enter the number of ");
            int num = Convert.ToInt32(Console.ReadLine());

            Sum3 s3 = new Sum3(num);
            s3.Marks(num);
            s3.displayResult(num);


            //Sum4 s4 = new Sum4();
            //s4.Strings();
            //Console.WriteLine("Enter the strings to compare: ");
            //string s5 = Console.ReadLine();
            //string s6 = Console.ReadLine();

            //s4.CompareStrings(s5, s6);

            Console.ReadLine();
        }
    }

    public class Sum1
    {
        public double ArrayEle(int[] a)
        {
            double avg;
            int total = 0;
            for (int i = 0; i < a.Length; i++)
            {
                total += a[i];
            }
            avg = total / a.Length;
            return avg;
        }

        public void MinMax(int[] a)
        {
            int max = a[0];
            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.WriteLine("The max value in the array: " + max + " The min value " + min);
        }
    }

    public class Sum2
    {
        public int[] Marks()
        {
            Console.WriteLine("Enter the marks of 10 students: ");
            int[] stMarks = new int[10];
            for (int i = 0; i < stMarks.Length; i++)
            {
                stMarks[i] = Convert.ToInt32(Console.ReadLine());
            }
            return stMarks;
        }

        public void Operations(int[] a)
        {
            double avg;
            int total = 0;
            for (int i = 0; i < a.Length; i++)
            {
                total += a[i];
            }
            avg = total / a.Length;
            Console.WriteLine("The total is: " + total + " The average is: " + avg);

            int max = a[0];
            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.WriteLine("The highest marks scored is: " + max + " The lowest marks is: " + min);


            int[] a1 = a;
            Array.Sort(a1);
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i] + " ");
            }
            Console.WriteLine();
            int[] a2 = a1;
            Array.Reverse(a2);
            for (int i = 0; i < a2.Length; i++)
            {
                Console.Write(a2[i] + " ");
            }
            Console.WriteLine();
        }


    }

    public class Sum3
    {
        int[] CSharp;
        int[] html;
        int[] Sql;

        public Sum3(int m)
        {
            CSharp = new int[m];
            html = new int[m];
            Sql = new int[m];
        }
        public void Marks(int m)
        {
            for(int i=0;i<m; i++)
            {
                Console.WriteLine("Enter the marks of Student" + i + 1);
                CSharp[i]= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the marks of Student" + i + 1);
                html[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the marks of Student" + i + 1);
                Sql[i] = Convert.ToInt32(Console.ReadLine());


            }
        }
        public void displayResult(int m)
        {
            for (int i = 0; i < m; i++)
            {
                int tot = CSharp[i] + html[i] + Sql[i];
                double avg = tot / 3;

                if (avg > 50)
                {
                    Console.WriteLine("Student" + i + 1);
                    Console.WriteLine("Result: PASS");
                }

                else
                {
                    Console.WriteLine("Student" + i + 1);
                    Console.WriteLine("Result: FAIL");
                }
            }

            
        }

    }
    public class Sum4
    {
        public void Strings()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            Console.WriteLine("Printing the string: " + s);
            //Console.WriteLine("Length of the string: " + s.Length);
            //char[] c = s.ToArray();
            //char temp;
            //int l = c.Length;
            //for (int i = 0; i < l / 2; i++)
            //{
            //    temp = c[i];
            //    c[i] = c[(l - i - 1)];
            //    c[(l - i - 1)] = temp;
            //}
            string s1= Convert.ToString(s.Reverse());

            //string s2 = new string(c);
            Console.WriteLine("The reversed string is: " + s1);

        }
        public void CompareStrings(string s1, string s2)
        {
            //char[] c1 = s1.ToArray();
            //char[] c2 = s2.ToArray();
            //bool flag = true;
            //for (int i = 0; i < c1.Length; i++)
            //{
            //    if (c1[i] != c2[i])
            //    {
            //        flag = false;
            //    }
            //}

            //if (flag == true)
            //{
            //    Console.Write("The strings are same");
            //}
            //else
            //{
            //    Console.Write("The strings are different");
            //}

            if (s1.Equals(s2))
            {
                Console.Write("The strings are same");
            }
            else
                Console.Write("The strings are different");
        }
    }
}

