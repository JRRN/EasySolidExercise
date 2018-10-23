﻿using System;
using CalcToSolid.SolidCalc;
using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;

namespace CalcToSolid
{
    class Program
    {
        private static readonly ISum _sum = new OperationSum(); //Interface segregation
        private static readonly IMul _mul = new OperationMul(); //Interface segregation
        private static readonly ISub _sub = new OperationSub(); //Interface segregation
        private static readonly IDiv _div = new OperationDiv(); //Interface segregation
        private static readonly IConverter _converter = new Converter(); //Interface segregation
        private static readonly IMenu _menu = new Menu(); //Interface segregation
        private static readonly INExpM _nExpM = new OperationNExpM();

        static void Main(string[] args)
        {
            //NoSolidOperation();
            SolidCalc();
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
            Console.WriteLine("4: NExpM");
            var operation = (OperationType)Console.Read();

            var result = new NoSolidCalc().Operation(operation, operand1, operand2);
            Console.WriteLine(result);
        }

        private static void SolidCalc() {

            var operand1 = _converter.ConvertStringToInt(_menu.PrintMenuOperand1());
            var operand2 = _converter.ConvertStringToInt(_menu.PrintMenuOperand2());
            var operation = _menu.PrintMenuOperation();

            if (operation.Equals(OperationType.DIV)) Console.Write (_div.Div(operand1, operand2));
            if (operation.Equals(OperationType.MUL)) Console.Write(_mul.Mul(operand1, operand2));
            if (operation.Equals(OperationType.SUB)) Console.Write(_sub.Sub(operand1, operand2));
            if (operation.Equals(OperationType.SUM)) Console.Write(_sum.Sum(operand1, operand2));
            if (operation.Equals(OperationType.NExpM)) Console.Write(_nExpM.NExpM(operand1, operand2));

        }
    }
}
