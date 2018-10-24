using System;
using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;

namespace CalcToSolid
{
    class Program
    {
        private static readonly IConverter _converter = new Converter(); //Interface segregation
        private static readonly IMenu _menu = new Menu(); //Interface segregation
        private static readonly ICalc _calc = new SolidCalc.Logic.SolidCalc(); //Interface segregation

        static void Main(string[] args)
        {
            //NoSolidOperation();
            SolidCalc();
        }

        private static void NoSolidOperation()
        {
            Console.WriteLine("Intro First Operand");
            var operand1 = Console.ReadLine();

            Console.WriteLine("Intro Second Operand");
            var operand2 = Console.ReadLine();

            Console.WriteLine("Intro Operation");
            Console.WriteLine("0: SUM");
            Console.WriteLine("1: SUB");
            Console.WriteLine("2: DIV");
            Console.WriteLine("3: MUL");
            Console.WriteLine("4: NExpM");
            var operation = (OperationType)Console.Read();

            var result = new NoSolidCalc().Operation(operation, operand1, operand2);
            Console.WriteLine(result);
        }

        private static void SolidCalc()
        {
            var operand1 = _converter.ConvertStringToInt(_menu.PrintMenuOperand1()); //Train Wreck - clean code
            var operand2 = _converter.ConvertStringToInt(_menu.PrintMenuOperand2()); //Train Wreck - clean code
            var operation = _menu.PrintMenuOperation();
            Console.WriteLine(_calc.DoOperation(operation, operand1, operand2));
            Console.ReadLine();
        }
    }
}
