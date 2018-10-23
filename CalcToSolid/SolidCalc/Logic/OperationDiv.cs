using System;
namespace CalcToSolid.SolidCalc.Logic
{
    public class OperationDiv : IDiv
    {
        public int Div(int operand1, int operand2) //Single responsibility
        {
            return operand1 / operand2;
        }
    }
}
