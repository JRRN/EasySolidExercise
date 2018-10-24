using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class OperationNExpM : INExpM
    {
        private static readonly IMul _mul = new OperationMul(); //Liskov 

        int INExpM.NExpM(int operand1, int operand2)
        {
            int result= operand1;

            for (int i=1; i < operand2; i++)
            {
                result = _mul.Mul(result, operand1);
            }
            return result;
        }
    }
}
