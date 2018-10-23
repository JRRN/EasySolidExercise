using System;
namespace CalcToSolid
{
    public class NoSolidCalc
    {

        public int Operation(OperationType operationType, string operand1, string operand2)
        {

            var parsed1 =  int.TryParse(operand1, out int operandOneParsed);
            var parsed2 = int.TryParse(operand2, out int operandTwoParsed);

            if(parsed1 && parsed2){
                if (operationType.Equals(OperationType.DIV))
                {
                    return operandOneParsed / operandTwoParsed;
                }

                if (operationType.Equals(OperationType.MUL))
                {
                    return operandOneParsed * operandTwoParsed;
                }
                if (operationType.Equals(OperationType.SUB))
                {
                    return operandOneParsed - operandTwoParsed;
                }
                if (operationType.Equals(OperationType.NExpM)){
                    var result = 0;

                    for (int i= 0; i< operandTwoParsed; i++){
                        result += operandOneParsed;
                    }
                    return result;
                }

                return operandOneParsed + operandTwoParsed;
            }
            return 0;
        }
    }

    public enum OperationType {
        SUM,
        SUB,
        DIV,
        MUL,
        NExpM
    }
}
