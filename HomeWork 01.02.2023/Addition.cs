using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_01._02._2023
{
    public sealed class Addition:Calculation
    {
        public override int Operate(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"first number = {a}, second number = {b}. Result = {result}");
            return result;
        }
    }
}
