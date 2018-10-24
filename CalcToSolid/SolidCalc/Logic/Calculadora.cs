using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class Calculadora : ICalculadora
    {
        private readonly IOperation _sumatory;
        private readonly IOperation _multiplication;
        private readonly IOperation _substraction;
        private readonly IOperation _division;
        private readonly IOperation _exponential;

        public Calculadora()
        {
            _sumatory = new OperationSum(); //Interface segregation
            _multiplication = new OperationMul(); //Interface segregation
            _substraction = new OperationSub(); //Interface segregation
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
                    return Substraction(operand1, operand2);
                case OperationType.Sum:
                    return Sumatory(operand1, operand2);
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

        private int Substraction(int operand1, int operand2)
        {
            return _substraction.Execute(operand1, operand2);
        }

        private int Sumatory(int operand1, int operand2)
        {
            return _sumatory.Execute(operand1, operand2);
        }

        private int Exponential(int operand1, int operand2)
        {
            return _exponential.Execute(operand1, operand2);
        }
    }
}