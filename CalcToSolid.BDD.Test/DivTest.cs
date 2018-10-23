using CalcToSolid.SolidCalc;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class DivTest
    {
        private static readonly IDiv _div = new OperationDiv();
        [Fact]
        public void GivenTwoNumberWhenApplyDivThenObtainResult()
        {
            var result = _div.Div(1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(0, result);
        }
    }
}
