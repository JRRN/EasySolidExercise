using CalcToSolid.SolidCalc;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class MulTest
    {
        private static readonly IMul _mul = new OperationMul();

        [Fact]
        public void GivenTwoNumberWhenApplyMulThenObtainResult()
        {
            var result = _mul.Mul(1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(3, result);
        }
    }
}
