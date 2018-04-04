using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_learn_project
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWrite WriteConsole = new ConsoleWrite();
            Calculate CalcFunction = new Calculate();
            for (double i = 0; i != 5;)
            {
                i = FunctionAdditionMet(ref CalcFunction, ref WriteConsole);
            } 
            Console.ReadKey();
        }
        static double FunctionAdditionMet(ref Calculate CalcFunction, ref ConsoleWrite WriteConsole)
        {
            WriteConsole.StartRead();
            int GetNameFunction = WriteConsole.GetFinctionNum;
            if (GetNameFunction < 5)
            {
                switch (GetNameFunction)
                {
                    case (0):
                        CalcFunction.FunctionAddition(WriteConsole.GetNumOne, WriteConsole.GetNumTwo);
                        WriteConsole.WriteResponse(CalcFunction.ResultFunction);
                        break;
                    case (1):
                        CalcFunction.FunctionMinus(WriteConsole.GetNumOne, WriteConsole.GetNumTwo);
                        WriteConsole.WriteResponse(CalcFunction.ResultFunction);
                        break;
                    case (2):
                        CalcFunction.FunctionMultiplication(WriteConsole.GetNumOne, WriteConsole.GetNumTwo);
                        WriteConsole.WriteResponse(CalcFunction.ResultFunction);
                        break;
                    case (3):
                        CalcFunction.FunctionDivision(WriteConsole.GetNumOne, WriteConsole.GetNumTwo);
                        WriteConsole.WriteResponse(CalcFunction.ResultFunction);
                        break;

                }
            }
            return GetNameFunction;
        }
    }
}