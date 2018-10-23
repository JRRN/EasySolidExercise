using CalcToSolid.SolidCalc;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class SolidCalcTest
    {
        private static readonly ISum _sum = new OperationSum();

        [Fact]
        public void GivenTwoNumberWhenApplySumThenObtainResult()
        {
            var result = _sum.Sum(1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(4,result);
        }
    }
}
