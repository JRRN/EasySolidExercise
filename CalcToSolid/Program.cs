using System;

namespace CalcToSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            NoSolidOperation();
        }

        private static void NoSolidOperation(){
            Console.WriteLine("Intro First Operand");
            var operand1 = Console.ReadLine();

            Console.WriteLine("Intro Second Operand");
            var operand2 = Console.ReadLine();

            Console.WriteLine("Intro Operation");
            Console.WriteLine("0: SUM");
            Console.WriteLine("1: SUB");
            Console.WriteLine("2: DIV");
            Console.WriteLine("3: MUL");
            var operation = (OperationType)Console.Read();

            var result = new NoSolidCalc().Operation(operation, operand1, operand2);
            Console.WriteLine(result);
        }
    }
}
