using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_learn_project
{
    class Calculate
    {
        double result;
        public double ResultFunction
        {
            get
            {
                return result;
            }
            private set
            {
                result = value;
            }
        }
        public void FunctionAddition(double first, double last)
        {
            ResultFunction = first + last;
        }
        public void FunctionMinus(double first, double last)
        {
            ResultFunction = first - last;
        }
        public void FunctionMultiplication(double first, double last)
        {
            ResultFunction = first * last;
        }
        public void FunctionDivision(double frist, double last)
        {
            if ((frist == 0) || (last == 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n На ноль делить нельзя!!! \n");
            }
            else
            {
                ResultFunction = frist / last;
            }
        }
        public void MatrixPifagor()
        {
            int[] OneString = new int[10];
            for (int i = 1; i < OneString.Length; i++)
            {
                for (int j = 1; j < OneString.Length; j++)
                {
                    Console.Write(" " + i * j);
                }
                Console.WriteLine(" ");
            }
        }
    }
}