using System;
using System.Linq;

namespace Example
{
    //    class Program
    //    {
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
    //}
}