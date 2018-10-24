﻿using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class OperationSub : IOperation
    {
        public int Execute(int operand1, int operand2) //Single responsibility
        {
            return operand1 - operand2;
        }
    }
}
