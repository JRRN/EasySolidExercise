using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class Calculadora : ICalculadora
    {
        private static readonly IOperation _operatin = new Operation(); //Interface segregation

        public int DoOperation(OperationType operation, int operand1, int operand2)
        {
           return _operatin.Execute(operation, operand1, operand2); 
        }
    }
}