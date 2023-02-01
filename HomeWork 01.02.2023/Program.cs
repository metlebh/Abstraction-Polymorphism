using System;

namespace HomeWork_01._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition n1 = new Addition();
            Substraction n2 = new Substraction();
            Multiplication n3 = new Multiplication();
            Division n4 = new Division();
            n1.Operate(5, 4);
            n2.Operate(10, 6);
            n3.Operate(20, 4);
            n4.Operate(100, 5);

        }
    }
}
