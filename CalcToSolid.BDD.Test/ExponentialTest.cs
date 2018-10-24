using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class ExponentialTest
    {
        private static readonly IOperation _exponential = new OperationNExpM();

        [Fact]
        public void GivenTwoNumberWhenApplyExpMThenObtainResult()
        {
            var result = _exponential.Execute(2, 3);
            Assert.IsType<int>(result);
            Assert.Equal(8, result);
        }
    }
}
