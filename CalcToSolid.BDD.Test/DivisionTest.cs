using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class DivisionTest
    {
        private static readonly IOperation _div = new OperationDiv();

        [Fact]
        public void GivenTwoNumberWhenApplyDivThenObtainResult()
        {
            var result = _div.Execute(1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(0, result);
        }
    }
}
