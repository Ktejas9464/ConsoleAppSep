using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day3
{
    internal class MethodCalling
    {
        internal void CallByValue(int x, int y)
        {
            x = x + 30;
            y = y + 20;
            Console.WriteLine($"x:{x}\ty:{y}");
        }

        internal void CallByRef(ref int x, ref int y)
        {
            x = x + 30;
            y = y + 20;
            Console.WriteLine($"x:{x}\ty:{y}");
        }
        internal void CallByOut(int num1, int num2, out int sum, out int multiply)
        {
            sum = num1 + num2;
            multiply = num1 * num2;
        }
        internal int CallByVarArgs(string name, params int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum = sum + item;
            }
            return sum;
        }

        //named and optional argument
        internal void Message(string fname, string surname = "Patil", float salary = 25000)
        {

            Console.WriteLine($"Welcome:{fname} {surname}");
            Console.WriteLine($"Salary:{salary}");
        }


    }
}