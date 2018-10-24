using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class Calculadora : ICalculadora
    {
        private static readonly IOperation _sum = new OperationSum(); //Interface segregation
        private static readonly IOperation _mul = new OperationMul(); //Interface segregation
        private static readonly IOperation _sub = new OperationSub(); //Interface segregation
        private static readonly IOperation _div = new OperationDiv(); //Interface segregation
        private static readonly IOperation _nExpM = new OperationNExpM(); //Interface segregation

        public int DoOperation(OperationType operation, int operand1, int operand2)
        {
            if (operation.Equals(OperationType.Div)) return _div.Execute(operand1, operand2);
            if (operation.Equals(OperationType.Mul)) return _mul.Execute(operand1, operand2);
            if (operation.Equals(OperationType.Sub)) return _sub.Execute(operand1, operand2);
            if (operation.Equals(OperationType.Sum)) return _sum.Execute(operand1, operand2);
            if (operation.Equals(OperationType.NExpM)) return _nExpM.Execute(operand1, operand2);
            return 0;
        }
    }
}