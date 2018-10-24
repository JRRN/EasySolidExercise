using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class SolidCalcTest
    {
        private static readonly IOperation _summatory = new OperationSum();

        [Fact]
        public void GivenTwoNumberWhenApplySumThenObtainResult()
        {
            var result = _summatory.Execute(1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(4,result);
        }
    }
}
