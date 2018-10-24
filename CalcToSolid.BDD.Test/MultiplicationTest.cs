using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class MultiplicationTest
    {
        private static readonly IOperation _multiplication = new OperationMul();

        [Fact]
        public void GivenTwoNumberWhenApplyMulThenObtainResult()
        {
            var result = _multiplication.Execute(1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(3, result);
        }
    }
}
