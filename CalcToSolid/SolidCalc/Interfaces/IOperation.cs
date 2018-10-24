namespace CalcToSolid.SolidCalc.Interfaces
{
    public interface IOperation 
    {
        int Execute(OperationType operation, int operand1, int operand2);
    }
}