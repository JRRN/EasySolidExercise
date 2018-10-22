using System;
namespace CalcToSolid.SolidCalc.Logic
{
    public class OperationDiv : IDiv
    {
        public int Div(int operand1, int operand2)
        {
            return operand1 / operand2;
        }
    }
}
