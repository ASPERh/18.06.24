using System;

namespace HW.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int[] arr = { 1, 11, 21, 1211, 111221, 312211, 13112221 };
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}