using System;
namespace CalcToSolid.SolidCalc.Logic
{
    public class OperationSub : ISub
    {
        public int Sub(int operand1, int operand2) //Single responsibility
        {
            return operand1 - operand2;
        }
    }
}
