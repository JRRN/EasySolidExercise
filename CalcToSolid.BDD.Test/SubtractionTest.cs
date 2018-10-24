using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class SubtractionTest
    {
        private static readonly IOperation _subtraction = new OperationSub();
        
        [Fact]
        public void GivenTwoNumberWhenApplySubThenObtainResult()
        {
            var result = _subtraction.Execute(1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(-2, result);
        }
    }
}
