﻿using System;

namespace git
{
    class Program
    {
    static void Main(string[] args)
        {
            int a=0, b=0;
            Console.WriteLine("Enter value for a: ");
            a= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for b: ");
            b= Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Subtraction {a}-{b} equals: {Subtraction(a, b)}");
        }
        public static int Subtraction(int a, int b)
        {
            return a-b;
        }
    }
}
