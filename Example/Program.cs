using System;
using System.Linq;

namespace Example
{
    class Program
    {
        //        string name, surname;
        //        int age;

        //        public void EnterIdentity()
        //        {
        //            Console.Write("\nPlease enter name: ");
        //            name = Console.ReadLine();

        //            Console.Write("\nPlease enter surname: ");
        //            surname = Console.ReadLine();

        //            Console.Write("\nPlease enter age: ");
        //            age = Convert.ToInt32(Console.ReadLine());
        //        }

        //        public void CallIdentity()
        //        {
        //            Console.Write("\nYour Name:" + name);

        //            Console.Write("\nPlease enter surname:" + surname);

        //            Console.Write("\nPlease enter age:" + age);
        //        }

        //        static void Main(string[] args)
        //        {
        //            Program p = new Program();
        //            p.EnterIdentity();
        //            p.CallIdentity();
        //            Console.ReadKey();
        //        }
        //    }


        //-----------------------------------------------------------------------------------------------------------------------------------------
        //Call the function take max value. Only positive!!!

        //public class Program
        //{
        //    int[] array = new int[] { -122, -25, 2, -16, -5 };

        //    public void callarray()
        //    {
        //        int max = array.Max();
        //        if (max>0)
        //        {
        //            Console.WriteLine(max);
        //        }
        //        else
        //        {
        //            Console.Write("Unfortunately, It isnt positive!");
        //        }

        //    }
        //    public static void Main(string[] args)
        //    {
        //        Program p = new Program();
        //        p.callarray();
        //    }
        //}


        //------------------------------------------------------------------------------------------------------------------------------------------------
        //MULTIDIMENSIONAL ARRAY C#
        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        int sum = 0;
        //        //int[,] arr = new int[3, 4]; declaration of 2D array  
        //        int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };      //declaration and initialization

        //        //traversal  
        //        for (int i = 0; i < 4; i++)
        //        {

        //            for (int j = 0; j < 3; j++) // write **** then go i, come back **** and again ****
        //            {
        //                Console.Write(arr[i, j] + " ");
        //                sum += arr[i,j];
        //            }

        //            Console.WriteLine();    //new line at each row  
        //        }
        //        Console.WriteLine(sum);
        //    }

        //}

        //------------------------------------------------------------------------------------------------------------------------------------------------

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {

        //        int[] array = { 1, 5, 77, 43, 23 };
        //        Console.WriteLine(string.Join("\t", array));

        //        int max = array.Max();

        //        foreach (int x in array)
        //        {
        //            int mltp = max - x;
        //            Console.Write(string.Join("   ", mltp,"   "));
        //        }

        //    }

        //------------------------------------------------------------------------------------------------------------------------------------------------

        public static void Main(string[] args)
        {
            //    Console.WriteLine("Sayı gir.");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Fibonacci(sayi);
            //}
            //public static void Fibonacci(int len)
            //{
            //    int[] dizi = new int[len];
            //    int a = 0, b = 1, c = 0;
            //    dizi[0] = a; dizi[1] = b;
            //    Console.Write("{0} {1}", a, b);
            //    for (int i = 2; i < len; i++)
            //    {
            //        c = a + b;
            //        Console.Write(" {0}", c);
            //        a = b;
            //        b = c;
            //        dizi[i] = c;
            //    }
            //    double sum = 0;
            //    double ortalama = 0;
            //    for (int i = 0; i < len; i++)
            //    {
            //        sum += dizi[i];
            //    }
            //    ortalama = sum / len;
            //    Console.WriteLine(" \nOrtalama= " + ortalama);
            //}

            Console.WriteLine("Array length: ");
            int func = Convert.ToInt32(Console.ReadLine());
            Fibonacci(func);
        }

        public static void Fibonacci(int num)
        {
            int[] array = new int[num];
            int n1 = 0, n2 = 1, n3;
            array[0] = n1; array[1] = n2;
            Console.Write("{0} {1}", n1, n2);

            for (int i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                array[i] = n3;
                Console.Write(" {0}", n3);
                n1 = n2;
                n2 = n3;
            }

            double sum = 0;
            double avg;

            for (int i = 0; i < num; i++)
            {
                sum += array[i];
            }

            avg = sum / num;
            Console.WriteLine(" \nAverage= " + avg);

        }
    }
}