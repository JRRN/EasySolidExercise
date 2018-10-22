using System;
using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class Menu : IMenu
    {
        public string PrintMenuOperand1()
        {
            Console.WriteLine("Intro First Operand");
            return Console.ReadLine();

        }

        public string PrintMenuOperand2()
        {
            Console.WriteLine("Intro Second Operand");
            return Console.ReadLine();
        }

        public OperationType PrintMenuOperation()
        {
            Console.WriteLine("Intro Operation");
            Console.WriteLine("0: SUM");
            Console.WriteLine("1: SUB");
            Console.WriteLine("2: DIV");
            Console.WriteLine("3: MUL");
            return (OperationType)Console.Read();
        }
    
    }
}
