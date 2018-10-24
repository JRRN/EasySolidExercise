using System;
using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class Menu : IMenu
    {
        public string PrintMenuOperand1() //Single responsibility)
        {
            Console.WriteLine("Intro First Operand");
            return Console.ReadLine();
        }

        public string PrintMenuOperand2() //Single responsibility)
        {
            Console.WriteLine("Intro Second Operand");
            return Console.ReadLine();
        }

        public OperationType PrintMenuOperation() //Single responsibility)
        {
            Console.WriteLine("Intro Operation");
            Console.WriteLine("0: SUM");
            Console.WriteLine("1: SUB");
            Console.WriteLine("2: DIV");
            Console.WriteLine("3: MUL");
            Console.WriteLine("4: NExpM");
            return (OperationType)Console.Read();
        }
    }
}
