using System;
namespace CalcToSolid.SolidCalc.Logic
{
    public class OperationSum : ISum
    {
        public int Sum(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
    }
}
