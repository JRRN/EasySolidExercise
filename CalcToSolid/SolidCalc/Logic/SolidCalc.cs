using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class SolidCalc : ICalc
    {
        private readonly IOperation _summatory;
        private readonly IOperation _multiplication;
        private readonly IOperation _subtraction;
        private readonly IOperation _division;
        private readonly IOperation _exponential;

        public SolidCalc()
        {
            _summatory = new OperationSum(); //Interface segregation
            _multiplication = new OperationMul(); //Interface segregation
            _subtraction = new OperationSub(); //Interface segregation
            _division = new OperationDiv(); //Interface segregation
            _exponential = new OperationNExpM(); //Interface segregation
        }

        public int DoOperation(OperationType operation, int operand1, int operand2)
        {
            switch (operation)
            {
                case OperationType.Div:
                    return Division(operand1, operand2);
                case OperationType.Mul:
                    return Multiplication(operand1, operand2);
                case OperationType.Sub:
                    return Subtraction(operand1, operand2);
                case OperationType.Sum:
                    return Summatory(operand1, operand2);
                case OperationType.NExpM:
                    return Exponential(operand1, operand2);
                default:
                    return 0;
            }
        }

        private int Division(int operand1, int operand2)
        {
            return _division.Execute(operand1, operand2);
        }

        private int Multiplication(int operand1, int operand2)
        {
            return _multiplication.Execute(operand1, operand2);
        }

        private int Subtraction(int operand1, int operand2)
        {
            return _subtraction.Execute(operand1, operand2);
        }

        private int Summatory(int operand1, int operand2)
        {
            return _summatory.Execute(operand1, operand2);
        }

        private int Exponential(int operand1, int operand2)
        {
            return _exponential.Execute(operand1, operand2);
        }
    }
}